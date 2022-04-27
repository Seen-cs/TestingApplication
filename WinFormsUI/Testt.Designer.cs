
namespace WinFormsUI
{
    partial class Testt
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_QuestionText = new System.Windows.Forms.Label();
            this.btn_AskQuestion = new System.Windows.Forms.Button();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_QuestionText
            // 
            this.lbl_QuestionText.AutoSize = true;
            this.lbl_QuestionText.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_QuestionText.Location = new System.Drawing.Point(247, 123);
            this.lbl_QuestionText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_QuestionText.Name = "lbl_QuestionText";
            this.lbl_QuestionText.Size = new System.Drawing.Size(590, 35);
            this.lbl_QuestionText.TabIndex = 0;
            this.lbl_QuestionText.Text = "Sınava Başlamak için \"Sınava başla\" butonuna basın.";
            this.lbl_QuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_AskQuestion
            // 
            this.btn_AskQuestion.Location = new System.Drawing.Point(476, 415);
            this.btn_AskQuestion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AskQuestion.Name = "btn_AskQuestion";
            this.btn_AskQuestion.Size = new System.Drawing.Size(164, 51);
            this.btn_AskQuestion.TabIndex = 1;
            this.btn_AskQuestion.Text = "Sınava Başla";
            this.btn_AskQuestion.UseVisualStyleBackColor = true;
            this.btn_AskQuestion.Click += new System.EventHandler(this.btn_AskQuestion_Click);
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(105, 290);
            this.btn_A.Margin = new System.Windows.Forms.Padding(5);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(161, 52);
            this.btn_A.TabIndex = 5;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Visible = false;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(352, 294);
            this.btn_B.Margin = new System.Windows.Forms.Padding(5);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(164, 51);
            this.btn_B.TabIndex = 6;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Visible = false;
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(581, 294);
            this.btn_C.Margin = new System.Windows.Forms.Padding(5);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(164, 51);
            this.btn_C.TabIndex = 7;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Visible = false;
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(807, 292);
            this.btn_D.Margin = new System.Windows.Forms.Padding(5);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(164, 51);
            this.btn_D.TabIndex = 8;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Visible = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 551);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.btn_AskQuestion);
            this.Controls.Add(this.lbl_QuestionText);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_QuestionText;
        private System.Windows.Forms.Button btn_AskQuestion;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
    }
}

