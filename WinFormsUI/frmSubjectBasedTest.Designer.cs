
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubjectBasedTest));
            this.pcbr_Image = new System.Windows.Forms.PictureBox();
            this.btn_Start_Test = new System.Windows.Forms.Button();
            this.lbl_QuestionText = new System.Windows.Forms.Label();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_C = new System.Windows.Forms.Label();
            this.lbl_D = new System.Windows.Forms.Label();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbr_Image
            // 
            this.pcbr_Image.BackColor = System.Drawing.Color.Transparent;
            this.pcbr_Image.Location = new System.Drawing.Point(521, 52);
            this.pcbr_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbr_Image.Name = "pcbr_Image";
            this.pcbr_Image.Size = new System.Drawing.Size(167, 104);
            this.pcbr_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbr_Image.TabIndex = 17;
            this.pcbr_Image.TabStop = false;
            // 
            // btn_Start_Test
            // 
            this.btn_Start_Test.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start_Test.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Start_Test.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Start_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start_Test.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_Start_Test.Location = new System.Drawing.Point(474, 396);
            this.btn_Start_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start_Test.Name = "btn_Start_Test";
            this.btn_Start_Test.Size = new System.Drawing.Size(214, 46);
            this.btn_Start_Test.TabIndex = 16;
            this.btn_Start_Test.Text = "Sınava Basla";
            this.btn_Start_Test.UseVisualStyleBackColor = false;
            this.btn_Start_Test.Click += new System.EventHandler(this.btn_Start_Test_Click);
            this.btn_Start_Test.MouseLeave += new System.EventHandler(this.btn_Start_Test_MouseLeave);
            this.btn_Start_Test.MouseHover += new System.EventHandler(this.btn_Start_Test_MouseHover);
            // 
            // lbl_QuestionText
            // 
            this.lbl_QuestionText.AutoSize = true;
            this.lbl_QuestionText.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QuestionText.Location = new System.Drawing.Point(12, 52);
            this.lbl_QuestionText.Name = "lbl_QuestionText";
            this.lbl_QuestionText.Size = new System.Drawing.Size(27, 15);
            this.lbl_QuestionText.TabIndex = 15;
            this.lbl_QuestionText.Text = "----";
            this.lbl_QuestionText.Visible = false;
            // 
            // btn_D
            // 
            this.btn_D.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_D.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_D.Location = new System.Drawing.Point(12, 327);
            this.btn_D.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(40, 38);
            this.btn_D.TabIndex = 14;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Visible = false;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_C
            // 
            this.btn_C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_C.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_C.Location = new System.Drawing.Point(12, 285);
            this.btn_C.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(40, 38);
            this.btn_C.TabIndex = 13;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Visible = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_B
            // 
            this.btn_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_B.Location = new System.Drawing.Point(12, 243);
            this.btn_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(40, 38);
            this.btn_B.TabIndex = 12;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Visible = false;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_A
            // 
            this.btn_A.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_A.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_A.Location = new System.Drawing.Point(12, 201);
            this.btn_A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(40, 38);
            this.btn_A.TabIndex = 11;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Visible = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.BackColor = System.Drawing.Color.Transparent;
            this.lbl_A.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_A.Location = new System.Drawing.Point(71, 208);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(34, 21);
            this.lbl_A.TabIndex = 18;
            this.lbl_A.Text = "----";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.BackColor = System.Drawing.Color.Transparent;
            this.lbl_B.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_B.Location = new System.Drawing.Point(71, 250);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(34, 21);
            this.lbl_B.TabIndex = 19;
            this.lbl_B.Text = "----";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.BackColor = System.Drawing.Color.Transparent;
            this.lbl_C.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_C.Location = new System.Drawing.Point(71, 292);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(34, 21);
            this.lbl_C.TabIndex = 20;
            this.lbl_C.Text = "----";
            // 
            // lbl_D
            // 
            this.lbl_D.AutoSize = true;
            this.lbl_D.BackColor = System.Drawing.Color.Transparent;
            this.lbl_D.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_D.Location = new System.Drawing.Point(71, 334);
            this.lbl_D.Name = "lbl_D";
            this.lbl_D.Size = new System.Drawing.Size(34, 21);
            this.lbl_D.TabIndex = 21;
            this.lbl_D.Text = "----";
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.BackgroundImage")));
            this.pcr_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Location = new System.Drawing.Point(661, 12);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(27, 23);
            this.pcr_Exit.TabIndex = 23;
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
            this.pcr_Back.TabIndex = 22;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
            // 
            // frmSubjectBasedTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 453);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.lbl_D);
            this.Controls.Add(this.lbl_C);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Controls.Add(this.pcbr_Image);
            this.Controls.Add(this.btn_Start_Test);
            this.Controls.Add(this.lbl_QuestionText);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSubjectBasedTest";
            this.Text = "frmSubjectBasedTest";
            this.Load += new System.EventHandler(this.frmSubjectBasedTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbr_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbr_Image;
        private System.Windows.Forms.Button btn_Start_Test;
        private System.Windows.Forms.Label lbl_QuestionText;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_C;
        private System.Windows.Forms.Label lbl_D;
        private System.Windows.Forms.PictureBox pcr_Exit;
        private System.Windows.Forms.PictureBox pcr_Back;
    }
}