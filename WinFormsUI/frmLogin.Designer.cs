
namespace WinFormsUI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.llbl_Register = new System.Windows.Forms.LinkLabel();
            this.llbl_IForgetMyPassword = new System.Windows.Forms.LinkLabel();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_UserName.Location = new System.Drawing.Point(283, 44);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(136, 29);
            this.txt_UserName.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(283, 77);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(136, 29);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_UserName.Location = new System.Drawing.Point(168, 47);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(109, 21);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "Kullanıcı Adı:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Password.Location = new System.Drawing.Point(229, 80);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(48, 21);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Şifre:";
            // 
            // btn_Login
            // 
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(337, 110);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(82, 33);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Giriş";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // llbl_Register
            // 
            this.llbl_Register.AutoSize = true;
            this.llbl_Register.BackColor = System.Drawing.Color.Transparent;
            this.llbl_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_Register.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.llbl_Register.LinkColor = System.Drawing.Color.MediumSlateBlue;
            this.llbl_Register.Location = new System.Drawing.Point(349, 155);
            this.llbl_Register.Name = "llbl_Register";
            this.llbl_Register.Size = new System.Drawing.Size(70, 21);
            this.llbl_Register.TabIndex = 5;
            this.llbl_Register.TabStop = true;
            this.llbl_Register.Text = "Kayıt Ol";
            this.llbl_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Register_LinkClicked);
            // 
            // llbl_IForgetMyPassword
            // 
            this.llbl_IForgetMyPassword.AutoSize = true;
            this.llbl_IForgetMyPassword.BackColor = System.Drawing.Color.Transparent;
            this.llbl_IForgetMyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbl_IForgetMyPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.llbl_IForgetMyPassword.LinkColor = System.Drawing.Color.Gray;
            this.llbl_IForgetMyPassword.Location = new System.Drawing.Point(284, 192);
            this.llbl_IForgetMyPassword.Name = "llbl_IForgetMyPassword";
            this.llbl_IForgetMyPassword.Size = new System.Drawing.Size(135, 21);
            this.llbl_IForgetMyPassword.TabIndex = 6;
            this.llbl_IForgetMyPassword.TabStop = true;
            this.llbl_IForgetMyPassword.Text = "Şifremi unuttum";
            this.llbl_IForgetMyPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_IForgetMyPassword_LinkClicked);
            // 
            // pcr_Exit
            // 
            this.pcr_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Exit.BackgroundImage")));
            this.pcr_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Exit.Location = new System.Drawing.Point(392, 5);
            this.pcr_Exit.Name = "pcr_Exit";
            this.pcr_Exit.Size = new System.Drawing.Size(27, 23);
            this.pcr_Exit.TabIndex = 7;
            this.pcr_Exit.TabStop = false;
            this.pcr_Exit.Click += new System.EventHandler(this.pcr_Exit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 220);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.llbl_IForgetMyPassword);
            this.Controls.Add(this.llbl_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.TextBox txt_UserName;
        public System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.LinkLabel llbl_Register;
        private System.Windows.Forms.LinkLabel llbl_IForgetMyPassword;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}