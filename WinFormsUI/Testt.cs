using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.DTOs;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Testt : Form
    {
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        UserManager userManager = new UserManager(new EfUserDal());
        StudentAnswerManager studentsAnswersManager = new StudentAnswerManager(new EfStudentAnswerDal());

        public string userName { get; set; }
        public string password { get; set; }

        Random random = new Random();
        List<int> randValue = new List<int>();
        int NumberOfQuestionsToBeAsked = 1;
        List<int> studentQuestionId = new List<int>();
        int questionIndex = 0;
        int questionNumberToBeAskedForTheFirstTime = 0;
        public void btn_AskQuestion_Click(object sender, EventArgs e)
        {
            btn_A.Visible = true;
            btn_B.Visible = true;
            btn_C.Visible = true;
            btn_D.Visible = true;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;

            var studentId = userManager.GetUserWithUserNameAndPassword(userName, password).Data.Id;
            var studentFirstLoginDate = userManager.GetUserWithUserNameAndPassword(userName, password).Data.FirstLoginDate;
            //int studentQuestionsCount = studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data.Count();
            if (DateTime.Now.Day == studentFirstLoginDate.Day + 1 ||
                DateTime.Now.Day == studentFirstLoginDate.Day + 7 ||
                DateTime.Now.Day == studentFirstLoginDate.Day + 30 ||
                DateTime.Now.Day == studentFirstLoginDate.Day + 90 ||
                DateTime.Now.Day == studentFirstLoginDate.Day + 365)
            {
                foreach (var item in studentsAnswersManager.GetAllStudentAnswerWithStudentId(studentId).Data)
                {
                    if (questionIndex == 0)
                    {
                        studentQuestionId.Add(item.QuestionId);
                    }

                }
                lbl_QuestionText.Text = studentsAnswersManager.GetStudentQuestionWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex]).Data.QuestionText;
                btn_A.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerA;
                btn_B.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerB;
                btn_C.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerC;
                btn_D.Text = questionManager.GetQuestionsById(studentQuestionId[questionIndex]).Data.AnswerD;
                if (questionIndex < studentQuestionId.Count())
                {
                    questionIndex++;
                }

            }



            //eger sayı gelmesse sonsuz döngü olur!!
            studentQuestionId.Clear();
            int questionID = random.Next(2, 7);
            while (NumberOfQuestionsToBeAsked != 0)
            {
                if (studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId,questionID).Success == false
                    && randValue.Contains(questionID) == false)//soru onceden sorulmamıssa
                {
                    studentQuestionId.Add(questionID);
                    lbl_QuestionText.Text = studentsAnswersManager.GetStudentQuestionWithStudentIdAndQuestionId(studentId, studentQuestionId[questionID]).Data.QuestionText;
                    btn_A.Text = questionManager.GetQuestionsById(studentQuestionId[questionID]).Data.AnswerA;
                    btn_B.Text = questionManager.GetQuestionsById(studentQuestionId[questionID]).Data.AnswerB;
                    btn_C.Text = questionManager.GetQuestionsById(studentQuestionId[questionID]).Data.AnswerC;
                    btn_C.Text = questionManager.GetQuestionsById(studentQuestionId[questionID]).Data.AnswerD;
                    NumberOfQuestionsToBeAsked--;
                    studentsAnswersManager.Add(new StudentAnswer 
                    {
                        QuestionId = studentQuestionId[questionID],
                        StudentId = studentId,
                        Validation = false,
                        SigmaCount = 0
                    });
                    //if (numberofquestionstobeasked == 0)
                    //{
                    //    break;
                    //}

                }
                //cok onemli hata PATLIYOR!!!
                // HATA: ilk soru sorulur sonraki soru daha ilk soru gözükmeden ekrana yazılır.
                // diğer soruyu soracak zaman bazlı olabilir 
                    randValue.Add(questionID);
                    Random random = new Random();
                    questionID = random.Next(2, 7);

                
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
            if (questionIndex+1 < studentQuestionId.Count())//sigmadan geldiyse
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionIndex]).Data;
                if (questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.AnswerA ==
                    questionManager.GetQuestionsById(studentQuestionId[questionIndex - 1]).Data.CorrectAnswer)//cevap dogruysa
                {
                    temp.Validation = true;
                    temp.SigmaCount++;
                    if (temp.SigmaCount==6) 
                    {
                        MessageBox.Show("sigma tamamlandı");
                    }
                    
                }
                else
                {
                    temp.Validation = false;
                    temp.SigmaCount = 0;
                }
                    

            }
            else //soru ilk defa soruluyorsa
            {
                temp = studentsAnswersManager.GetStudentAnswerWithStudentIdAndQuestionId(studentId, studentQuestionId[questionNumberToBeAskedForTheFirstTime]).Data;                
                
                questionNumberToBeAskedForTheFirstTime++;
                if (questionManager.GetQuestionsById(studentQuestionId[questionNumberToBeAskedForTheFirstTime]).Data.AnswerA ==
                    questionManager.GetQuestionsById(studentQuestionId[questionNumberToBeAskedForTheFirstTime]).Data.CorrectAnswer)//cevap dogruysa
                {
                    temp.Validation = true;
                    temp.SigmaCount++;
                    if (temp.SigmaCount == 6)
                    {
                        MessageBox.Show("sigma tamamlandı");
                        // sigma tamamlanmakodları
                    }

                }
                else
                {
                    temp.Validation = false;
                    temp.SigmaCount = 0;
                }
            }
            studentsAnswersManager.Update(temp);
            

        }
    }
}

