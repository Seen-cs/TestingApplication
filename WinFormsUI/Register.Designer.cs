
namespace WinFormsUI
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.cmbb_UserType = new System.Windows.Forms.ComboBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı adı:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(160, 54);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(125, 27);
            this.txt_UserName.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(160, 99);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(125, 27);
            this.txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parola:";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(160, 157);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(125, 27);
            this.txt_FirstName.TabIndex = 5;
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(46, 160);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(35, 20);
            this.lbl_FirstName.TabIndex = 4;
            this.lbl_FirstName.Text = "Adı:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(160, 210);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(125, 27);
            this.txt_LastName.TabIndex = 7;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(46, 213);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(57, 20);
            this.lbl_LastName.TabIndex = 6;
            this.lbl_LastName.Text = "Soyadı:";
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(311, 354);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(94, 29);
            this.btn_Register.TabIndex = 8;
            this.btn_Register.Text = "Kayıt Ol";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Location = new System.Drawing.Point(44, 312);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(116, 20);
            this.lbl_UserType.TabIndex = 10;
            this.lbl_UserType.Text = "Kullanıcı Tipiniz:";
            // 
            // cmbb_UserType
            // 
            this.cmbb_UserType.FormattingEnabled = true;
            this.cmbb_UserType.Items.AddRange(new object[] {
            "Öğrenci",
            "Eğitmen",
            "Admin"});
            this.cmbb_UserType.Location = new System.Drawing.Point(166, 304);
            this.cmbb_UserType.Name = "cmbb_UserType";
            this.cmbb_UserType.Size = new System.Drawing.Size(119, 28);
            this.cmbb_UserType.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(160, 261);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(125, 27);
            this.txt_email.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-posta:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 435);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.cmbb_UserType);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.ComboBox cmbb_UserType;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
    }
}