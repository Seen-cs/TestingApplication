﻿using Businiess.Concrete;
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
        List<int> studentQuestionIdToBeFirstTimeAsked = new List<int>();
        List<int> studentQuestionId = new List<int>();
        List<int> studentQuestionIdForSigma = new List<int>();
        int NumberOfQuestionsToBeAsked = 3;
        int questionIndex = 0;
        public string userName { get; set; }
        public string password { get; set; }
        /*

                soruların resimli olması seceneği eklenmeli

        */
        public void btn_AskQuestion_Click(object sender, EventArgs e)
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
            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;

            if (questionIndex>=0 && studentQuestionIdForSigma.Count()>questionIndex)
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
            
            if (questionIndex > studentQuestionId.Count()|| questionIndex == 0 || questionIndex==-1)
            {
                //eger sayı gelmesse sonsuz döngü olur!!
                 //questionIndex = -1;
                 studentQuestionIdToBeFirstTimeAsked.Clear();

                //bu kodu kotrol et
                //bu kod sorulacak soru sayısı tabloda yoksa olan kadarını sormaya yarar
                if (studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Success == true)
                {
                    if (questionManager.GetAll().Data.Count() -
                studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count()
                < NumberOfQuestionsToBeAsked)
                        NumberOfQuestionsToBeAsked = questionManager.GetAll().Data.Count() -
                        studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count();
                }


                if (NumberOfQuestionsToBeAsked == 0)
                {
                    MessageBox.Show("Sınav bitti");
                    this.Hide();
                }
                Random random = new Random();
                int questionID = random.Next(1, 8);
                
                while (NumberOfQuestionsToBeAsked != 0)
                {
                    if (studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, questionID).Success == false
                        && randValue.Contains(questionID) == false)//soru onceden sorulmamıssa
                    {
                        randValue.Add(questionID);
                        studentQuestionIdToBeFirstTimeAsked.Add(questionID);
                        lbl_QuestionText.Text = questionManager.GetQuestionsById(questionID).Data.QuestionText;
                        btn_A.Text = questionManager.GetQuestionsById(questionID).Data.AnswerA;
                        btn_B.Text = questionManager.GetQuestionsById(questionID).Data.AnswerB;
                        btn_C.Text = questionManager.GetQuestionsById(questionID).Data.AnswerC;
                        btn_D.Text = questionManager.GetQuestionsById(questionID).Data.AnswerD;
                        NumberOfQuestionsToBeAsked--;
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
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionIdToBeFirstTimeAsked[0]).Data;
                if (questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.AnswerA ==
                    questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.CorrectAnswer)//cevap dogruysa
                {
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
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionIdToBeFirstTimeAsked[0]).Data;
                if (questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.AnswerB ==
                    questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.CorrectAnswer)//cevap dogruysa
                {
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
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionIdToBeFirstTimeAsked[0]).Data;
                if (questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.AnswerC ==
                    questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.CorrectAnswer)//cevap dogruysa
                {
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
                    temp.SigmaCount++;
                    studentsAnswersManager.Update(temp);
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }

                }
                else
                {
                    studentsAnswersManager.Delete(temp);
                }
                if (studentQuestionId.Count == questionIndex)
                {
                    questionIndex = -1;
                }


            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionIdToBeFirstTimeAsked[0]).Data;
                if (questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.AnswerD ==
                    questionManager.GetQuestionsById(studentQuestionIdToBeFirstTimeAsked[0]).Data.CorrectAnswer)//cevap dogruysa
                {
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
    }
}
