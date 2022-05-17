using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class frmExamResult : Form
    {
        public frmExamResult()
        {
            InitializeComponent();
        }
        public int StudentId { get; set; }
        UserManager userManager = new UserManager(new EfUserDal());
        StudentAnswerManager studentAnswerManager = new StudentAnswerManager(new EfStudentAnswerDal());
        UnitManager unitManager = new UnitManager(new EfUnitDal());
        QuestionManager questionManager = new QuestionManager(new EfQuestionDal());
        List<decimal> totalSigmaCountInTheUnit = new List<decimal>();
        List<decimal> totalNumberOfQuestionsInTheUnit = new List<decimal>();
        List<decimal> numberOfQuestionsAnsweredInTheUnit = new List<decimal>();
        decimal totalSigmaCount;
        decimal numberOfQuestionsAnswered;
        decimal leastKnownUnit;
        int leastKnownUnitId=1;

        private void ExamResult_Load(object sender, EventArgs e)
        {
            
          
            foreach (var unit in unitManager.GetAll().Data)
            {
                totalNumberOfQuestionsInTheUnit.Add(questionManager.GetAllQuestionWithUnitId(unit.UnitId).Data.Count());
                foreach (var item in studentAnswerManager.GetAllStudentAnswerWithStudentIdAndQuestionUnit(StudentId, unit.UnitId).Data)
                {
                    totalSigmaCount += item.SigmaCount;
                    numberOfQuestionsAnswered++;
                }
                totalSigmaCountInTheUnit.Add(totalSigmaCount);
                numberOfQuestionsAnsweredInTheUnit.Add(numberOfQuestionsAnswered);
                totalSigmaCount = 0;
                numberOfQuestionsAnswered = 0;
            }
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
 
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString("Öğrenim Formu", myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Konu Adı", myFont, sbrush, 140, 328);
            e.Graphics.DrawString("Çözülen Soru Yüzdesi", myFont, sbrush, 240, 328);
            e.Graphics.DrawString("Ortalama Sigma Sayısı", myFont, sbrush, 440, 328);
            e.Graphics.DrawString("Öğrenim Yüzdesi", myFont, sbrush, 640, 328);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            leastKnownUnit = Math.Round(((totalSigmaCountInTheUnit[0] / (totalNumberOfQuestionsInTheUnit[0] * 6)) * 100), 2);
            foreach (var item in unitManager.GetAll().Data)
            {
                e.Graphics.DrawString(item.UnitName, myFont, sbrush, 160, y, myStringFormat);
                if (totalSigmaCountInTheUnit.IndexOf(item.UnitId - 1) != 0)
                {
                    e.Graphics.DrawString(Math.Round(((numberOfQuestionsAnsweredInTheUnit[item.UnitId - 1] / totalNumberOfQuestionsInTheUnit[item.UnitId - 1]) * 100), 2).ToString(), myFont, sbrush, 220, y);
                    e.Graphics.DrawString(Math.Round((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)), 2).ToString(), myFont, sbrush, 530, y, myStringFormat);
                    e.Graphics.DrawString(Math.Round(((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)) * 100), 2).ToString(), myFont, sbrush, 700, y, myStringFormat);
                    if (leastKnownUnit> Math.Round(((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)) * 100), 2))
                    {
                        leastKnownUnit = Math.Round(((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)) * 100), 2);
                        leastKnownUnitId = item.UnitId;
                    }
                    
                }
                else
                {
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 220, y);
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 530, y, myStringFormat);
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 700, y, myStringFormat);
                }

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);

 
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {


            frmSubjectBasedTest frmSubjectBasedTest = new frmSubjectBasedTest()
            {
                LeastKnownUnitId = leastKnownUnitId
            };
            frmSubjectBasedTest.Show();
            this.Hide();
        }

        private void btn_SigmaPeriyot_Click(object sender, EventArgs e)
        {
            var temp = userManager.GetUserWithId(StudentId).Data;
            temp.SigmaPeriod1 = Convert.ToInt32(txt_SigmaPeriod1.Text);
            temp.SigmaPeriod2 = Convert.ToInt32(txt_SigmaPeriod2.Text);
            temp.SigmaPeriod3 = Convert.ToInt32(txt_SigmaPeriod3.Text);
            temp.SigmaPeriod4 = Convert.ToInt32(txt_SigmaPeriod4.Text);
            temp.SigmaPeriod5 = Convert.ToInt32(txt_SigmaPeriod5.Text);
            userManager.Update(temp);
            Console.WriteLine("Değiştirildi");
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Preview_MouseHover(object sender, EventArgs e)
        {
            btn_Preview.ForeColor = Color.Yellow;
        }

        private void btn_Preview_MouseLeave(object sender, EventArgs e)
        {
            btn_Preview.ForeColor = Color.Black;
        }

        private void Btn_Print_MouseHover(object sender, EventArgs e)
        {
            Btn_Print.ForeColor = Color.Orange;
        }

        private void Btn_Print_MouseLeave(object sender, EventArgs e)
        {
            Btn_Print.ForeColor = Color.Black;
        }

        private void btn_Test_MouseHover(object sender, EventArgs e)
        {
            btn_Test.ForeColor = Color.Green;   
        }

        private void btn_Test_MouseLeave(object sender, EventArgs e)
        {
            btn_Test.ForeColor = Color.Black;
        }

        private void btn_SigmaPeriyot_MouseHover(object sender, EventArgs e)
        {
            btn_SigmaPeriyot.ForeColor = Color.Green;
        }

        private void btn_SigmaPeriyot_MouseLeave(object sender, EventArgs e)
        {
            btn_SigmaPeriyot.ForeColor = Color.Black;
        }
    }
}
