
namespace WinFormsUI
{
    partial class Test
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
            this.components = new System.ComponentModel.Container();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.lbl_QuestionText = new System.Windows.Forms.Label();
            this.btn_AskQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Minute = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Second = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcbr_Image = new System.Windows.Forms.PictureBox();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_D = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(29, 312);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(63, 51);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Visible = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(29, 369);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(63, 51);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Visible = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_C.Location = new System.Drawing.Point(29, 426);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(63, 51);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Visible = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(29, 492);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(63, 51);
            this.btn_D.TabIndex = 3;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Visible = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // lbl_QuestionText
            // 
            this.lbl_QuestionText.AutoSize = true;
            this.lbl_QuestionText.Location = new System.Drawing.Point(29, 80);
            this.lbl_QuestionText.Name = "lbl_QuestionText";
            this.lbl_QuestionText.Size = new System.Drawing.Size(33, 20);
            this.lbl_QuestionText.TabIndex = 4;
            this.lbl_QuestionText.Text = "----";
            this.lbl_QuestionText.Visible = false;
            this.lbl_QuestionText.Click += new System.EventHandler(this.lbl_QuestionText_Click);
            // 
            // btn_AskQuestion
            // 
            this.btn_AskQuestion.Location = new System.Drawing.Point(560, 488);
            this.btn_AskQuestion.Name = "btn_AskQuestion";
            this.btn_AskQuestion.Size = new System.Drawing.Size(244, 62);
            this.btn_AskQuestion.TabIndex = 5;
            this.btn_AskQuestion.Text = "Sınava Basla";
            this.btn_AskQuestion.UseVisualStyleBackColor = true;
            this.btn_AskQuestion.Click += new System.EventHandler(this.btn_AskQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(649, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalan Süre:";
            this.label1.Visible = false;
            // 
            // lbl_Minute
            // 
            this.lbl_Minute.AutoSize = true;
            this.lbl_Minute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Minute.Location = new System.Drawing.Point(776, 19);
            this.lbl_Minute.Name = "lbl_Minute";
            this.lbl_Minute.Size = new System.Drawing.Size(28, 28);
            this.lbl_Minute.TabIndex = 7;
            this.lbl_Minute.Text = "--";
            this.lbl_Minute.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(821, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            this.label3.Visible = false;
            // 
            // lbl_Second
            // 
            this.lbl_Second.AutoSize = true;
            this.lbl_Second.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Second.Location = new System.Drawing.Point(849, 19);
            this.lbl_Second.Name = "lbl_Second";
            this.lbl_Second.Size = new System.Drawing.Size(28, 28);
            this.lbl_Second.TabIndex = 9;
            this.lbl_Second.Text = "--";
            this.lbl_Second.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcbr_Image
            // 
            this.pcbr_Image.Location = new System.Drawing.Point(454, 70);
            this.pcbr_Image.Name = "pcbr_Image";
            this.pcbr_Image.Size = new System.Drawing.Size(303, 178);
            this.pcbr_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbr_Image.TabIndex = 10;
            this.pcbr_Image.TabStop = false;
            this.pcbr_Image.Click += new System.EventHandler(this.pcbr_Image_Click);
            // 
            // lbl_A
            // 
            this.lbl_A.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(110, 327);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(33, 20);
            this.lbl_A.TabIndex = 11;
            this.lbl_A.Text = "----";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(110, 384);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(33, 20);
            this.lbl_B.TabIndex = 12;
            this.lbl_B.Text = "----";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Location = new System.Drawing.Point(110, 441);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(33, 20);
            this.lbl_C.TabIndex = 13;
            this.lbl_C.Text = "----";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Location = new System.Drawing.Point(110, 507);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(33, 20);
            this.lbl_D.TabIndex = 14;
            this.lbl_D.Text = "----";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 579);
            this.Controls.Add(this.lbl_D);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.pcbr_Image);
            this.Controls.Add(this.lbl_Second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Minute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_AskQuestion);
            this.Controls.Add(this.lbl_QuestionText);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Label lbl_QuestionText;
        private System.Windows.Forms.Button btn_AskQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Minute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Second;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbr_Image;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_D;
    }
}