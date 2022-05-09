
namespace WinFormsUI
{
    partial class ExamResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamResult));
            this.lbl_ExamResult = new System.Windows.Forms.Label();
            this.btn_Preview = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SigmaPeriod1 = new System.Windows.Forms.TextBox();
            this.txt_SigmaPeriod2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SigmaPeriod3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SigmaPeriod4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SigmaPeriod5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ExamResult
            // 
            this.lbl_ExamResult.AutoSize = true;
            this.lbl_ExamResult.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExamResult.Location = new System.Drawing.Point(217, 58);
            this.lbl_ExamResult.Name = "lbl_ExamResult";
            this.lbl_ExamResult.Size = new System.Drawing.Size(340, 26);
            this.lbl_ExamResult.TabIndex = 0;
            this.lbl_ExamResult.Text = "Tebrikler sınavı tamamladınız";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Location = new System.Drawing.Point(527, 312);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(94, 29);
            this.btn_Preview.TabIndex = 5;
            this.btn_Preview.Text = "Ön İzleme";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Location = new System.Drawing.Point(640, 312);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(94, 29);
            this.Btn_Print.TabIndex = 4;
            this.Btn_Print.Text = "Yazdır";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "PrintDocument1";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(527, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rapor Almak İçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "1. Sigma Periyotu:";
            // 
            // txt_SigmaPeriod1
            // 
            this.txt_SigmaPeriod1.Location = new System.Drawing.Point(180, 141);
            this.txt_SigmaPeriod1.Name = "txt_SigmaPeriod1";
            this.txt_SigmaPeriod1.Size = new System.Drawing.Size(125, 27);
            this.txt_SigmaPeriod1.TabIndex = 8;
            // 
            // txt_SigmaPeriod2
            // 
            this.txt_SigmaPeriod2.Location = new System.Drawing.Point(180, 192);
            this.txt_SigmaPeriod2.Name = "txt_SigmaPeriod2";
            this.txt_SigmaPeriod2.Size = new System.Drawing.Size(125, 27);
            this.txt_SigmaPeriod2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "2. Sigma Periyotu:";
            // 
            // txt_SigmaPeriod3
            // 
            this.txt_SigmaPeriod3.Location = new System.Drawing.Point(180, 251);
            this.txt_SigmaPeriod3.Name = "txt_SigmaPeriod3";
            this.txt_SigmaPeriod3.Size = new System.Drawing.Size(125, 27);
            this.txt_SigmaPeriod3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "3. Sigma Periyotu:";
            // 
            // txt_SigmaPeriod4
            // 
            this.txt_SigmaPeriod4.Location = new System.Drawing.Point(180, 301);
            this.txt_SigmaPeriod4.Name = "txt_SigmaPeriod4";
            this.txt_SigmaPeriod4.Size = new System.Drawing.Size(125, 27);
            this.txt_SigmaPeriod4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "4. Sigma Periyotu:";
            // 
            // txt_SigmaPeriod5
            // 
            this.txt_SigmaPeriod5.Location = new System.Drawing.Point(180, 359);
            this.txt_SigmaPeriod5.Name = "txt_SigmaPeriod5";
            this.txt_SigmaPeriod5.Size = new System.Drawing.Size(125, 27);
            this.txt_SigmaPeriod5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "5. Sigma Periyotu:";
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SigmaPeriod5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SigmaPeriod4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SigmaPeriod3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SigmaPeriod2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SigmaPeriod1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.lbl_ExamResult);
            this.Name = "ExamResult";
            this.Text = "ExamResult";
            this.Load += new System.EventHandler(this.ExamResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExamResult;
        private System.Windows.Forms.Button btn_Preview;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SigmaPeriod1;
        private System.Windows.Forms.TextBox txt_SigmaPeriod2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SigmaPeriod3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SigmaPeriod4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SigmaPeriod5;
        private System.Windows.Forms.Label label6;
    }
}