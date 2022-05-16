
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
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_SigmaPeriyot = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ExamResult
            // 
            this.lbl_ExamResult.AutoSize = true;
            this.lbl_ExamResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExamResult.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_ExamResult.Location = new System.Drawing.Point(166, 7);
            this.lbl_ExamResult.Name = "lbl_ExamResult";
            this.lbl_ExamResult.Size = new System.Drawing.Size(356, 32);
            this.lbl_ExamResult.TabIndex = 0;
            this.lbl_ExamResult.Text = "Tebrikler sınavı tamamladınız";
            // 
            // btn_Preview
            // 
            this.btn_Preview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Preview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Preview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Preview.Location = new System.Drawing.Point(398, 160);
            this.btn_Preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Preview.Name = "btn_Preview";
            this.btn_Preview.Size = new System.Drawing.Size(115, 49);
            this.btn_Preview.TabIndex = 6;
            this.btn_Preview.Text = "Ön İzleme";
            this.btn_Preview.UseVisualStyleBackColor = true;
            this.btn_Preview.Click += new System.EventHandler(this.btn_Preview_Click);
            this.btn_Preview.MouseLeave += new System.EventHandler(this.btn_Preview_MouseLeave);
            this.btn_Preview.MouseHover += new System.EventHandler(this.btn_Preview_MouseHover);
            // 
            // Btn_Print
            // 
            this.Btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Btn_Print.Location = new System.Drawing.Point(535, 160);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(115, 49);
            this.Btn_Print.TabIndex = 7;
            this.Btn_Print.Text = "Yazdır";
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            this.Btn_Print.MouseLeave += new System.EventHandler(this.Btn_Print_MouseLeave);
            this.Btn_Print.MouseHover += new System.EventHandler(this.Btn_Print_MouseHover);
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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(440, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rapor Almak İçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "1. Sigma Periyodu:";
            // 
            // txt_SigmaPeriod1
            // 
            this.txt_SigmaPeriod1.Location = new System.Drawing.Point(154, 25);
            this.txt_SigmaPeriod1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SigmaPeriod1.Name = "txt_SigmaPeriod1";
            this.txt_SigmaPeriod1.Size = new System.Drawing.Size(110, 23);
            this.txt_SigmaPeriod1.TabIndex = 0;
            // 
            // txt_SigmaPeriod2
            // 
            this.txt_SigmaPeriod2.Location = new System.Drawing.Point(154, 52);
            this.txt_SigmaPeriod2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SigmaPeriod2.Name = "txt_SigmaPeriod2";
            this.txt_SigmaPeriod2.Size = new System.Drawing.Size(110, 23);
            this.txt_SigmaPeriod2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "2. Sigma Periyodu:";
            // 
            // txt_SigmaPeriod3
            // 
            this.txt_SigmaPeriod3.Location = new System.Drawing.Point(154, 79);
            this.txt_SigmaPeriod3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SigmaPeriod3.Name = "txt_SigmaPeriod3";
            this.txt_SigmaPeriod3.Size = new System.Drawing.Size(110, 23);
            this.txt_SigmaPeriod3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(5, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "3. Sigma Periyodu:";
            // 
            // txt_SigmaPeriod4
            // 
            this.txt_SigmaPeriod4.Location = new System.Drawing.Point(154, 105);
            this.txt_SigmaPeriod4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SigmaPeriod4.Name = "txt_SigmaPeriod4";
            this.txt_SigmaPeriod4.Size = new System.Drawing.Size(110, 23);
            this.txt_SigmaPeriod4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "4. Sigma Periyodu:";
            // 
            // txt_SigmaPeriod5
            // 
            this.txt_SigmaPeriod5.Location = new System.Drawing.Point(154, 132);
            this.txt_SigmaPeriod5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SigmaPeriod5.Name = "txt_SigmaPeriod5";
            this.txt_SigmaPeriod5.Size = new System.Drawing.Size(110, 23);
            this.txt_SigmaPeriod5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(5, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "5. Sigma Periyodu:";
            // 
            // btn_Test
            // 
            this.btn_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Test.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Test.Location = new System.Drawing.Point(398, 216);
            this.btn_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(252, 53);
            this.btn_Test.TabIndex = 8;
            this.btn_Test.Text = "Eksik Olduğum Konudaki Sınava Git";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            this.btn_Test.MouseLeave += new System.EventHandler(this.btn_Test_MouseLeave);
            this.btn_Test.MouseHover += new System.EventHandler(this.btn_Test_MouseHover);
            // 
            // btn_SigmaPeriyot
            // 
            this.btn_SigmaPeriyot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SigmaPeriyot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SigmaPeriyot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SigmaPeriyot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SigmaPeriyot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_SigmaPeriyot.Location = new System.Drawing.Point(52, 161);
            this.btn_SigmaPeriyot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SigmaPeriyot.Name = "btn_SigmaPeriyot";
            this.btn_SigmaPeriyot.Size = new System.Drawing.Size(212, 52);
            this.btn_SigmaPeriyot.TabIndex = 5;
            this.btn_SigmaPeriyot.Text = "Sınav Olma Periyotlarını Onayla";
            this.btn_SigmaPeriyot.UseVisualStyleBackColor = true;
            this.btn_SigmaPeriyot.Click += new System.EventHandler(this.btn_SigmaPeriyot_Click);
            this.btn_SigmaPeriyot.MouseLeave += new System.EventHandler(this.btn_SigmaPeriyot_MouseLeave);
            this.btn_SigmaPeriyot.MouseHover += new System.EventHandler(this.btn_SigmaPeriyot_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_SigmaPeriod3);
            this.groupBox1.Controls.Add(this.btn_SigmaPeriyot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SigmaPeriod1);
            this.groupBox1.Controls.Add(this.txt_SigmaPeriod5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_SigmaPeriod2);
            this.groupBox1.Controls.Add(this.txt_SigmaPeriod4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(21, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınav Olma Periyotları";
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.BackgroundImage")));
            this.pcr_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Location = new System.Drawing.Point(661, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(27, 23);
            this.pcr_Exit.TabIndex = 22;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 295);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Preview);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.lbl_ExamResult);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExamResult";
            this.Text = "ExamResult";
            this.Load += new System.EventHandler(this.ExamResult_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
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
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_SigmaPeriyot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}