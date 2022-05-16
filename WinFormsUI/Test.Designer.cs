
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
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
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.question_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            this.question_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_A
            // 
            this.btn_A.BackColor = System.Drawing.Color.Transparent;
            this.btn_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_A.Location = new System.Drawing.Point(12, 388);
            this.btn_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(55, 38);
            this.btn_A.TabIndex = 0;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = false;
            this.btn_A.Visible = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.BackColor = System.Drawing.Color.Transparent;
            this.btn_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_B.Location = new System.Drawing.Point(12, 430);
            this.btn_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(55, 38);
            this.btn_B.TabIndex = 1;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = false;
            this.btn_B.Visible = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Transparent;
            this.btn_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_C.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_C.Location = new System.Drawing.Point(12, 472);
            this.btn_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(55, 38);
            this.btn_C.TabIndex = 2;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Visible = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.BackColor = System.Drawing.Color.Transparent;
            this.btn_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_D.Location = new System.Drawing.Point(12, 514);
            this.btn_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(55, 38);
            this.btn_D.TabIndex = 3;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = false;
            this.btn_D.Visible = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // lbl_QuestionText
            // 
            this.lbl_QuestionText.AutoSize = true;
            this.lbl_QuestionText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_QuestionText.Location = new System.Drawing.Point(13, 14);
            this.lbl_QuestionText.Name = "lbl_QuestionText";
            this.lbl_QuestionText.Size = new System.Drawing.Size(46, 21);
            this.lbl_QuestionText.TabIndex = 4;
            this.lbl_QuestionText.Text = "------";
            this.lbl_QuestionText.Visible = false;
            this.lbl_QuestionText.Click += new System.EventHandler(this.lbl_QuestionText_Click);
            // 
            // btn_AskQuestion
            // 
            this.btn_AskQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_AskQuestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AskQuestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AskQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AskQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AskQuestion.Location = new System.Drawing.Point(552, 559);
            this.btn_AskQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AskQuestion.Name = "btn_AskQuestion";
            this.btn_AskQuestion.Size = new System.Drawing.Size(214, 46);
            this.btn_AskQuestion.TabIndex = 5;
            this.btn_AskQuestion.Text = "Sınava Basla";
            this.btn_AskQuestion.UseVisualStyleBackColor = false;
            this.btn_AskQuestion.Click += new System.EventHandler(this.btn_AskQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(569, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kalan Süre:";
            this.label1.Visible = false;
            // 
            // lbl_Minute
            // 
            this.lbl_Minute.AutoSize = true;
            this.lbl_Minute.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Minute.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Minute.Location = new System.Drawing.Point(680, 63);
            this.lbl_Minute.Name = "lbl_Minute";
            this.lbl_Minute.Size = new System.Drawing.Size(22, 21);
            this.lbl_Minute.TabIndex = 7;
            this.lbl_Minute.Text = "--";
            this.lbl_Minute.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(719, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = ".";
            this.label3.Visible = false;
            // 
            // lbl_Second
            // 
            this.lbl_Second.AutoSize = true;
            this.lbl_Second.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Second.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Second.Location = new System.Drawing.Point(744, 63);
            this.lbl_Second.Name = "lbl_Second";
            this.lbl_Second.Size = new System.Drawing.Size(22, 21);
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
            this.pcbr_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbr_Image.Location = new System.Drawing.Point(440, 98);
            this.pcbr_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbr_Image.Name = "pcbr_Image";
            this.pcbr_Image.Size = new System.Drawing.Size(326, 169);
            this.pcbr_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbr_Image.TabIndex = 10;
            this.pcbr_Image.TabStop = false;
            this.pcbr_Image.Click += new System.EventHandler(this.pcbr_Image_Click);
            // 
            // lbl_A
            // 
            this.lbl_A.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_A.AutoSize = true;
            this.lbl_A.Location = new System.Drawing.Point(88, 402);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(27, 15);
            this.lbl_A.TabIndex = 11;
            this.lbl_A.Text = "----";
            this.lbl_A.Visible = false;
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.Location = new System.Drawing.Point(88, 444);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(27, 15);
            this.lbl_B.TabIndex = 12;
            this.lbl_B.Text = "----";
            this.lbl_B.Visible = false;
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.Location = new System.Drawing.Point(88, 486);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(27, 15);
            this.lbl_C.TabIndex = 13;
            this.lbl_C.Text = "----";
            this.lbl_C.Visible = false;
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.Location = new System.Drawing.Point(88, 528);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(27, 15);
            this.lbl_D.TabIndex = 14;
            this.lbl_D.Text = "----";
            this.lbl_D.Visible = false;
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.BackgroundImage")));
            this.pcr_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Location = new System.Drawing.Point(739, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(27, 23);
            this.pcr_Exit.TabIndex = 15;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Back.BackgroundImage")));
            this.pcr_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Location = new System.Drawing.Point(12, 12);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(27, 23);
            this.pcr_Back.TabIndex = 16;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // question_Panel
            // 
            this.question_Panel.BackColor = System.Drawing.Color.Transparent;
            this.question_Panel.Controls.Add(this.lbl_QuestionText);
            this.question_Panel.Location = new System.Drawing.Point(12, 98);
            this.question_Panel.Name = "question_Panel";
            this.question_Panel.Size = new System.Drawing.Size(422, 285);
            this.question_Panel.TabIndex = 17;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 616);
            this.Controls.Add(this.question_Panel);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.pcr_Exit);
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
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            this.question_Panel.ResumeLayout(false);
            this.question_Panel.PerformLayout();
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
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.Panel question_Panel;
    }
}