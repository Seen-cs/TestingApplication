using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class TrainerPanel : Form
    {
        QuestionToAddManager questionToAdd = new QuestionToAddManager(new EFQuestionToAddDal());
       
        public TrainerPanel()
        {
            InitializeComponent();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            picture_Image.ImageLocation = openFileDialog1.FileName;
            txt_Image.Text = openFileDialog1.FileName;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            QuestionToAdd question = new QuestionToAdd();
            question.UnitId = 0;
            if (cmb_Unit.Text == "Matematik")
            {
                question.UnitId = 2;
            }
            else if (cmb_Unit.Text == "Fizik")
            {
                question.UnitId = 1;
            }
            else if (cmb_Unit.Text == "Kimya")
            {
                question.UnitId = 3;

            }
            else if(cmb_Unit.Text=="Biyoloji")
            {
                question.UnitId = 4;

            }
            
            question.QuestionText = txt_QuestionText.Text;
            question.QuestionImage = txt_Image.Text;
            question.AnswerA = txt_A.Text;
            question.AnswerB = txt_B.Text;
            question.AnswerC = txt_C.Text;
            question.AnswerD = txt_D.Text;
            if (question.UnitId!=0)
            {
                if (check_A.Checked == true)
                {
                    question.CorrectAnswer = txt_A.Text;
                    questionToAdd.Add(question);
                    MessageBox.Show("Kaydedildi");
                    check();
                    clear();


                }
                else if (check_B.Checked == true)
                {

                    question.CorrectAnswer = txt_B.Text;
                    questionToAdd.Add(question);
                    MessageBox.Show("Kaydedildi");
                    check();
                    clear();

                }
                else if (check_C.Checked == true)
                {
                    

                    question.CorrectAnswer = txt_C.Text;
                    questionToAdd.Add(question);
                    MessageBox.Show("Kaydedildi");
                    check();
                    clear();

                }
                else if (check_D.Checked == true)
                {
                    

                    question.CorrectAnswer = txt_D.Text;
                    questionToAdd.Add(question);
                    MessageBox.Show("Kaydedildi");
                    check();
                    clear();

                }
                else
                {
                    MessageBox.Show("Dogru Cevabı Seçiniz");

                }
            }
            else
            {
                MessageBox.Show("Konuyu Boş Bırakamazsınız");
            }
            void clear()
            {
                txt_Image.Clear();
                txt_QuestionText.Clear();
                txt_A.Clear();
                txt_B.Clear();
                txt_C.Clear();
                txt_D.Clear();
                cmb_Unit.Text = "";
                picture_Image.ImageLocation = "";
            }
            void check()
            {
                check_A.Checked = false;
                check_B.Checked = false;
                check_C.Checked = false;
                check_D.Checked = false;

            }


        }

        private void check_A_CheckedChanged(object sender, EventArgs e)
        {
            check_B.Checked = false;
            check_C.Checked = false;
            check_D.Checked = false;
            
        }

        private void check_B_CheckedChanged(object sender, EventArgs e)
        {
            check_A.Checked = false;
            check_C.Checked = false;
            check_D.Checked = false;
        }

        private void check_C_CheckedChanged(object sender, EventArgs e)
        {
            check_B.Checked = false;
            check_A.Checked = false;
            check_D.Checked = false;
        }

        private void check_D_CheckedChanged(object sender, EventArgs e)
        {
            check_B.Checked = false;
            check_C.Checked = false;
            check_A.Checked = false;
        }

        private void btn_Save_MouseHover(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.Green;
        }

        private void btn_Save_MouseLeave(object sender, EventArgs e)
        {
            btn_Save.ForeColor = Color.Black;
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
