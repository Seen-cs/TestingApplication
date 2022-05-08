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
    public partial class ExamResult : Form
    {
        public ExamResult()
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

        //private void btn_AnalysisReport_Click(object sender, EventArgs e)
        //{
        //    PrintAnalysisReport printAnalysisReport = new PrintAnalysisReport() {StudentId = this.StudentId };
        //    printAnalysisReport.Show();
        //    this.Hide();
        //}

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
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
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

            //decimal gTotal = 0;

            foreach (var item in unitManager.GetAll().Data)
            {
                e.Graphics.DrawString(item.UnitName, myFont, sbrush, 160, y, myStringFormat);
                if (totalSigmaCountInTheUnit.IndexOf(item.UnitId - 1) != 0)
                {
                    e.Graphics.DrawString(Math.Round(((numberOfQuestionsAnsweredInTheUnit[item.UnitId - 1] / totalNumberOfQuestionsInTheUnit[item.UnitId - 1]) * 100), 2).ToString(), myFont, sbrush, 220, y);
                    e.Graphics.DrawString(Math.Round((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)), 2).ToString(), myFont, sbrush, 530, y, myStringFormat);
                    e.Graphics.DrawString(Math.Round(((totalSigmaCountInTheUnit[item.UnitId - 1] / (totalNumberOfQuestionsInTheUnit[item.UnitId - 1] * 6)) * 100), 2).ToString(), myFont, sbrush, 700, y, myStringFormat);
                }
                else
                {
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 220, y);
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 530, y, myStringFormat);
                    e.Graphics.DrawString(0.ToString(), myFont, sbrush, 700, y, myStringFormat);
                }
                //decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                //decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                //gTotal += fiyat;

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            //e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);
        }

    }
}
