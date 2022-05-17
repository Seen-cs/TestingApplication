using Businiess.Concrete;
using DataAccess;
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
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }
        QuestionToAddManager questionToAdd = new QuestionToAddManager(new EFQuestionToAddDal());
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        TestingApplicationContext testingApplicationContext = new TestingApplicationContext();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Question.Text == "")
            {
                MessageBox.Show("Lutfen Bir soru seçiniz");
            }
            else
            {
                Question question = new Question();
                question.QuestionText = txt_Question.Text;
                question.AnswerA = txt_A.Text;
                question.AnswerB = txt_B.Text;
                question.AnswerC = txt_C.Text;
                question.AnswerD = txt_D.Text;
                question.CorrectAnswer = txt_TrueSection.Text;
                question.UnitId = Convert.ToInt32(txt_Unit.Text);
                question.QuestionImagePath = txt_Image.Text;
                questionManager.Add(question);
                MessageBox.Show("başarılı bir şekilde kaydedildi");

                var questionId = questionToAdd.GetQuestionToAddWithQuestionText(txt_Question.Text).Data;
                questionToAdd.Delete(questionId);
                clear();
                dataGridView();
            }

        }
        void clear()
        {
            txt_Question.Clear();
            txt_A.Clear();
            txt_B.Clear();
            txt_C.Clear();
            txt_D.Clear();
            txt_TrueSection.Clear();
            txt_Unit.Clear();
            txt_Image.Clear();
            pcr_Question_Image.ImageLocation = "";

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dataGridView();
        }
        void dataGridView() 
        { 
            dataGridView1.DataSource = testingApplicationContext.QuestionToAdds.ToList();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_Question.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_A.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txt_B.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_C.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txt_D.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txt_TrueSection.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            txt_Unit.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txt_Image.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            pcr_Question_Image.ImageLocation = txt_Image.Text;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_Question.Text == "")
            {
                MessageBox.Show("Lütfen soru secin");
            }
            else
            {
                var questionId = questionToAdd.GetQuestionToAddWithQuestionText(txt_Question.Text).Data;
                questionToAdd.Delete(questionId);
                clear();
                dataGridView();
            }
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btn_Register_MouseHover(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.Green;
        }

        private void btn_Register_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.Black;
        }

        private void btn_Delete_MouseHover(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.Red;
        }

        private void btn_Delete_MouseLeave(object sender, EventArgs e)
        {
            btn_Delete.ForeColor = Color.Black;
        }
    }
}
