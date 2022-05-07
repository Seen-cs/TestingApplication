
namespace WinFormsUI
{
    partial class AdminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Question = new System.Windows.Forms.TextBox();
            this.txt_A = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_D = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TrueSection = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Unit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(702, 416);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(94, 52);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "Kaydet";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru:";
            // 
            // txt_Question
            // 
            this.txt_Question.Location = new System.Drawing.Point(120, 215);
            this.txt_Question.Name = "txt_Question";
            this.txt_Question.Size = new System.Drawing.Size(187, 27);
            this.txt_Question.TabIndex = 3;
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(120, 254);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(187, 27);
            this.txt_A.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "A)";
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(120, 295);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(187, 27);
            this.txt_B.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "B)";
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(120, 339);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(187, 27);
            this.txt_C.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "C)";
            // 
            // txt_D
            // 
            this.txt_D.Location = new System.Drawing.Point(120, 384);
            this.txt_D.Name = "txt_D";
            this.txt_D.Size = new System.Drawing.Size(187, 27);
            this.txt_D.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "D)";
            // 
            // txt_TrueSection
            // 
            this.txt_TrueSection.Location = new System.Drawing.Point(120, 429);
            this.txt_TrueSection.Name = "txt_TrueSection";
            this.txt_TrueSection.Size = new System.Drawing.Size(187, 27);
            this.txt_TrueSection.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dogru Cevap:";
            // 
            // txt_Unit
            // 
            this.txt_Unit.Location = new System.Drawing.Point(120, 467);
            this.txt_Unit.Name = "txt_Unit";
            this.txt_Unit.Size = new System.Drawing.Size(187, 27);
            this.txt_Unit.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Soru Konusu:";
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(120, 513);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(187, 27);
            this.txt_Image.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 516);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Soru Resmi:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(825, 416);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 52);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 572);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Unit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TrueSection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_D);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_C);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_B);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_A);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Question;
        private System.Windows.Forms.TextBox txt_A;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_D;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TrueSection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Unit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Delete;
    }
}