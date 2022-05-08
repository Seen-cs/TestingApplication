using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Test : Form
    {

        public Test()
        {
            InitializeComponent();
        }

        StudentAnswerManager studentsAnswersManager = new StudentAnswerManager(new EfStudentAnswerDal());
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        UserManager userManager = new UserManager(new EfUserDal());
        List<int> randValue = new List<int>();
        //List<int> studentQuestionIdToBeFirstTimeAsked = new List<int>();
        List<int> studentQuestionId = new List<int>();
        List<int> studentQuestionIdForSigma = new List<int>();
        int numberOfQuestionsToBeAsked = 3;
        int questionIndex = 0;
        int timer = 0;
        int second = 60;
        int minute = 0;
        int questionID;
        public string userName { get; set; }
        public string password { get; set; }
        /*

                soruların resimli olması seceneği eklenmeli

        */
        public void btn_AskQuestion_Click(object sender, EventArgs e)
        {
            if (userManager.GetUserWithUserNameAndPassword(userName, password).Data.LastLoginDate == DateTime.Today)
            {
                MessageBox.Show("Bugünkü sınavınızı zaten tamamladınız. Yarın yine bekleriz :)");
                this.Hide();
            }
            

            Design();
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            var student = userManager.GetUserWithUserNameAndPassword(userName, password).Data;
            if (questionIndex >= 0 && studentQuestionIdForSigma.Count() > questionIndex)
            {
                var questionAskDate = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionIdForSigma[questionIndex]).Data.QuestionAskDate;
                // int studentQuestionsCount = studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count();
                if (DateTime.Now.Day == questionAskDate.Day + 1 ||
                    DateTime.Now.Day == questionAskDate.Day + 7 ||
                    DateTime.Now.Day == questionAskDate.Day + 30 ||
                    DateTime.Now.Day == questionAskDate.Day + 90 ||
                    DateTime.Now.Day == questionAskDate.Day + 365)
                {
                    foreach (var item in studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data)
                    {
                        if (questionIndex == 0)
                        {
                            studentQuestionId.Add(item.QuestionId);
                        }

                    }
                    if (questionIndex < studentQuestionId.Count() && questionIndex != -1)
                    {
                        lbl_QuestionText.Text = studentsAnswersManager.GetStudentQuestionWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex]).Data.QuestionText;
                        pcbr_Image.ImageLocation = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.QuestionImagePath;
                        btn_A.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerA;
                        btn_B.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerB;
                        btn_C.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerC;
                        btn_D.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerD;
                        questionIndex++;
                    }

                    //if (questionIndex <= studentQuestionId.Count() && questionIndex != -1)
                    //{
                    //    questionIndex++;
                    //}

                }
            }




            if (timer == 0)
            {
                timer1.Start();
                if ((questionManager.GetAll().Data.Count - studentQuestionIdForSigma.Count) > 10)
                {
                    minute = studentQuestionId.Count() + 10;
                }
                else
                {
                    minute = (questionManager.GetAll().Data.Count - studentQuestionIdForSigma.Count) + studentQuestionId.Count;
                }

            }
            timer++;
            if (questionIndex > studentQuestionId.Count() || questionIndex == 0 || questionIndex == -1)
            {
                //eger sayı gelmesse sonsuz döngü olur!!
                //questionIndex = -1;
               

                //bu kodu kotrol et
                //bu kod sorulacak soru sayısı tabloda yoksa olan kadarını sormaya yarar
                if (studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Success == true)
                {
                    if (questionManager.GetAll().Data.Count() -
                studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count()
                < numberOfQuestionsToBeAsked)
                        numberOfQuestionsToBeAsked = questionManager.GetAll().Data.Count() -
                        studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count();
                }


                if (numberOfQuestionsToBeAsked == 0)
                {
                    MessageBox.Show("Sınav bitti");
                    var temp = userManager.GetUserWithUserNameAndPassword(userName, password).Data;
                    temp.LastLoginDate = DateTime.Today;
                    userManager.Update(temp);
                    ExamResult examResult = new ExamResult()
                    { StudentId= userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id
                    };
                    examResult.Show();
                    this.Hide();
                }
                Random random = new Random();
                questionID = random.Next(1, 8);

                while (numberOfQuestionsToBeAsked != 0)
                {
                    if (studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Success == false
                        && randValue.Contains(questionID) == false)//soru onceden sorulmamıssa
                    {
                        randValue.Add(questionID);
                        
                        lbl_QuestionText.Text = questionManager.GetQuestionsById(questionID).Data.QuestionText;
                        pcbr_Image.ImageLocation = questionManager.GetQuestionsById(questionID).Data.QuestionImagePath;
                        btn_A.Text = questionManager.GetQuestionsById(questionID).Data.AnswerA;
                        btn_B.Text = questionManager.GetQuestionsById(questionID).Data.AnswerB;
                        btn_C.Text = questionManager.GetQuestionsById(questionID).Data.AnswerC;
                        btn_D.Text = questionManager.GetQuestionsById(questionID).Data.AnswerD;
                        numberOfQuestionsToBeAsked--;
                        studentsAnswersManager.Add(new StudentAnswer
                        {
                            QuestionId = questionID,
                            StudentId = studentId,
                            SigmaCount = 0
                        });
                        break;

                    }
                    //cok onemli hata PATLIYOR!!!
                    // HATA: ilk soru sorulur sonraki soru daha ilk soru gözükmeden ekrana yazılır.
                    // diğer soruyu soracak zaman bazlı olabilir 
                    //cozuldu gibi

                    else
                    {
                        Random random1 = new Random();
                        questionID = random1.Next(1, 8);
                    }

                }


            }
        }

        private void Design()
        {
            btn_AskQuestion.Text = "Sonraki soru-->";
            lbl_QuestionText.Visible = true;
            btn_A.Visible = true;
            btn_B.Visible = true;
            btn_C.Visible = true;
            btn_D.Visible = true;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            lbl_Minute.Visible = true;
            lbl_Second.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            btn_A.BackColor = Color.White;
            btn_B.BackColor = Color.White;
            btn_C.BackColor = Color.White;
            btn_D.BackColor = Color.White;
        }

        public void btn_A_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            //------verilen cevabı tabloya atma
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            StudentAnswer temp = null;
            if (questionIndex > 0)//sigmadan geldiyse
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex-1]).Data;
                if (questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.AnswerA ==
                    questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_A.BackColor = Color.Green;
                   
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    btn_A.BackColor = Color.Red;
                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Data;
                if (questionManager.GetQuestionsById(questionID).Data.AnswerA ==
                    questionManager.GetQuestionsById(questionID).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_A.BackColor = Color.Green;
                    temp.SigmaCount++;
                    temp.QuestionAskDate = DateTime.Now;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                        // sigma tamamlanmakodları
                    }

                }
                else
                {
                    btn_A.BackColor = Color.Red;
                    studentsAnswersManager.Delete(temp);
                }
            }
            


        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            //------verilen cevabı tabloya atma
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            StudentAnswer temp = null;
            if (questionIndex > 0)//sigmadan geldiyse
            {
                
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex - 1]).Data;
                if (questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.AnswerB ==
                    questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_B.BackColor = Color.Green;

                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    btn_B.BackColor = Color.Red;

                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Data;
                if (questionManager.GetQuestionsById(questionID).Data.AnswerB ==
                    questionManager.GetQuestionsById(questionID).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_B.BackColor = Color.Green;

                    temp.SigmaCount++;
                    temp.QuestionAskDate = DateTime.Now;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                        // sigma tamamlanmakodları
                    }

                }
                else
                {
                    btn_B.BackColor = Color.Red;
                    studentsAnswersManager.Delete(temp);
                }
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            //------verilen cevabı tabloya atma
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            StudentAnswer temp = null;
            if (questionIndex > 0)//sigmadan geldiyse
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex - 1]).Data;
                if (questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.AnswerC ==
                    questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_C.BackColor = Color.Green;

                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    btn_C.BackColor = Color.Red;

                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Data;
                if (questionManager.GetQuestionsById(questionID).Data.AnswerC ==
                    questionManager.GetQuestionsById(questionID).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_C.BackColor = Color.Green;

                    temp.SigmaCount++;
                    temp.QuestionAskDate = DateTime.Now;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                        // sigma tamamlanmakodları
                    }

                }
                else
                {
                    btn_C.BackColor = Color.Red;

                    studentsAnswersManager.Delete(temp);
                }
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            //------verilen cevabı tabloya atma
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            StudentAnswer temp = null;
            if (questionIndex > 0)//sigmadan geldiyse
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex - 1]).Data;
                if (questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.AnswerD ==
                    questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_D.BackColor = Color.Green;
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    btn_D.BackColor = Color.Red;

                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Data;
                if (questionManager.GetQuestionsById(questionID).Data.AnswerD ==
                    questionManager.GetQuestionsById(questionID).Data.CorrectAnswer)//cevap dogruysa
                {
                    btn_D.BackColor = Color.Green;

                    temp.SigmaCount++;
                    temp.QuestionAskDate = DateTime.Now;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                        // sigma tamamlanmakodları
                    }

                }
                else
                {
                    btn_D.BackColor = Color.Red;

                    studentsAnswersManager.Delete(temp);
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            if (studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Success==true)
            {
                foreach (var item in studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data)
                {
                    studentQuestionIdForSigma.Add(item.QuestionId);

                }

            }
            

        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            second = second - 1;
            lbl_Second.Text = second.ToString();
            lbl_Minute.Text = (minute - 1).ToString();
            if (second ==0)
            {
                minute--;
                lbl_Minute.Text = minute.ToString();
                second = 60;
            }
            if (lbl_Minute.Text==Convert.ToString(0)&&lbl_Second.Text==Convert.ToString(0))
            {
                
                timer1.Enabled = false;
                MessageBox.Show("sınav bitti");
                var temp = userManager.GetUserWithUserNameAndPassword(userName, password).Data;
                temp.LastLoginDate = DateTime.Today;
                userManager.Update(temp);
                ExamResult examResult = new ExamResult()
                { StudentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id
                };
                examResult.Show();
                this.Hide();
               
            }
        }
    }
}
