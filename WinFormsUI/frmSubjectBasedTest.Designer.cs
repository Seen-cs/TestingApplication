
namespace WinFormsUI
{
    partial class frmSubjectBasedTest
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
            this.pcbr_Image = new System.Windows.Forms.PictureBox();
            this.btn_AskQuestion = new System.Windows.Forms.Button();
            this.lbl_QuestionText = new System.Windows.Forms.Label();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbr_Image
            // 
            this.pcbr_Image.Location = new System.Drawing.Point(49, 35);
            this.pcbr_Image.Name = "pcbr_Image";
            this.pcbr_Image.Size = new System.Drawing.Size(191, 139);
            this.pcbr_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbr_Image.TabIndex = 17;
            this.pcbr_Image.TabStop = false;
            // 
            // btn_AskQuestion
            // 
            this.btn_AskQuestion.Location = new System.Drawing.Point(307, 353);
            this.btn_AskQuestion.Name = "btn_AskQuestion";
            this.btn_AskQuestion.Size = new System.Drawing.Size(244, 62);
            this.btn_AskQuestion.TabIndex = 16;
            this.btn_AskQuestion.Text = "Sınava Basla";
            this.btn_AskQuestion.UseVisualStyleBackColor = true;
            this.btn_AskQuestion.Click += new System.EventHandler(this.btn_AskQuestion_Click);
            // 
            // lbl_QuestionText
            // 
            this.lbl_QuestionText.AutoSize = true;
            this.lbl_QuestionText.Location = new System.Drawing.Point(303, 95);
            this.lbl_QuestionText.Name = "lbl_QuestionText";
            this.lbl_QuestionText.Size = new System.Drawing.Size(33, 20);
            this.lbl_QuestionText.TabIndex = 15;
            this.lbl_QuestionText.Text = "----";
            this.lbl_QuestionText.Visible = false;
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(591, 216);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(161, 51);
            this.btn_D.TabIndex = 14;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Visible = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_C
            // 
            this.btn_C.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_C.Location = new System.Drawing.Point(397, 216);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(154, 51);
            this.btn_C.TabIndex = 13;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Visible = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(234, 216);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(102, 51);
            this.btn_B.TabIndex = 12;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Visible = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(80, 216);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(117, 51);
            this.btn_A.TabIndex = 11;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Visible = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // frmSubjectBasedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbr_Image);
            this.Controls.Add(this.btn_AskQuestion);
            this.Controls.Add(this.lbl_QuestionText);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Name = "frmSubjectBasedTest";
            this.Text = "frmSubjectBasedTest";
            this.Load += new System.EventHandler(this.frmSubjectBasedTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbr_Image;
        private System.Windows.Forms.Button btn_AskQuestion;
        private System.Windows.Forms.Label lbl_QuestionText;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
    }
}