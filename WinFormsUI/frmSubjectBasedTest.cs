using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class frmSubjectBasedTest : Form
    {
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        public frmSubjectBasedTest()
        {
            InitializeComponent();
        }
        public int LeastKnownUnitId { get; set; }
        List<int> questionId=new List<int>();
        int numberQuestion = -1;

        private void btn_Start_Test_Click(object sender, EventArgs e)
        {
            Design();
           // btn_AskQuestion.Text = "Sonraki Soru";
            var questionIdCount=questionId.Count;


            if (numberQuestion<10 && numberQuestion!=questionIdCount-1)
            {
                btnEnableTrue();
                numberQuestion++;
                lbl_QuestionText.Text = questionManager.GetQuestionsById(questionId[numberQuestion]).Data.QuestionText;
                lbl_A.Text = questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerA;
                lbl_B.Text = questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerB;
                lbl_C.Text = questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerC;
                lbl_D.Text = questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerD;
                
            }
            
            else
            {
                MessageBox.Show("Sınav Bitti ");
                btn_Start_Test.Enabled = false;
            }
        }
        void btnEnableFalse()
        {
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
        }
        void btnEnableTrue()
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            if (questionManager.GetQuestionsById(questionId[numberQuestion]).Data.CorrectAnswer==questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerA)
            {
                btn_A.BackColor = Color.Green;
                btnEnableFalse();
            }
            else
            {
                btn_A.BackColor = Color.Red;
                btnEnableFalse();

            }
        }

        private void btn_B_Click(object sender, EventArgs e)
        {
            if (questionManager.GetQuestionsById(questionId[numberQuestion]).Data.CorrectAnswer == questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerB)
            {
                btn_B.BackColor = Color.Green;
                btnEnableFalse();
            }
            else
            {
                btn_B.BackColor = Color.Red;
                btnEnableFalse();

            }
        }
        private void Design()
        {
            btn_Start_Test.Text = "Sonraki soru-->";
            lbl_QuestionText.Visible = true;
            btn_A.Visible = true;
            btn_B.Visible = true;
            btn_C.Visible = true;
            btn_D.Visible = true;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;  
            btn_A.BackColor = Color.White;
            btn_B.BackColor = Color.White;
            btn_C.BackColor = Color.White;
            btn_D.BackColor = Color.White;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            if (questionManager.GetQuestionsById(questionId[numberQuestion]).Data.CorrectAnswer == questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerC)
            {
                btn_C.BackColor = Color.Green;
                btnEnableFalse();
            }
            else
            {
                btn_C.BackColor = Color.Red;
                btnEnableFalse();

            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            if (questionManager.GetQuestionsById(questionId[numberQuestion]).Data.CorrectAnswer == questionManager.GetQuestionsById(questionId[numberQuestion]).Data.AnswerD)
            {
                btn_D.BackColor = Color.Green;
                btnEnableFalse();
            }
            else
            {
                btn_D.BackColor = Color.Red;
                btnEnableFalse();

            }
        }

        private void frmSubjectBasedTest_Load(object sender, EventArgs e)
        {
            foreach (var item in questionManager.GetAllQuestionWithUnitId(LeastKnownUnitId).Data)
            {
                questionId.Add(item.Id);
            }
        }

        private void btn_Start_Test_MouseHover(object sender, EventArgs e)
        {
            btn_Start_Test.ForeColor = Color.Green;
        }

        private void btn_Start_Test_MouseLeave(object sender, EventArgs e)
        {
            btn_Start_Test.ForeColor = Color.Black;
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            ExamResult examResult = new ExamResult();
            examResult.Show();
            this.Hide();
        }
    }
}
