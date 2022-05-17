
namespace WinFormsUI
{
    partial class frmIForgetMyPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIForgetMyPassword));
            this.btn_SendAnEmail = new System.Windows.Forms.Button();
            this.lbl_UaerName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.pcr_Back = new System.Windows.Forms.PictureBox();
            this.pcr_Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SendAnEmail
            // 
            this.btn_SendAnEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SendAnEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SendAnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendAnEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_SendAnEmail.Location = new System.Drawing.Point(178, 133);
            this.btn_SendAnEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SendAnEmail.Name = "btn_SendAnEmail";
            this.btn_SendAnEmail.Size = new System.Drawing.Size(110, 46);
            this.btn_SendAnEmail.TabIndex = 0;
            this.btn_SendAnEmail.Text = "Eposta Gönder";
            this.btn_SendAnEmail.UseVisualStyleBackColor = true;
            this.btn_SendAnEmail.Click += new System.EventHandler(this.btn_SendAnEmail_Click);
            // 
            // lbl_UaerName
            // 
            this.lbl_UaerName.AutoSize = true;
            this.lbl_UaerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UaerName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_UaerName.Location = new System.Drawing.Point(47, 77);
            this.lbl_UaerName.Name = "lbl_UaerName";
            this.lbl_UaerName.Size = new System.Drawing.Size(125, 21);
            this.lbl_UaerName.TabIndex = 1;
            this.lbl_UaerName.Text = "Kulanıcı adınız:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(178, 79);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(110, 23);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(178, 106);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(110, 23);
            this.txt_Email.TabIndex = 4;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(38, 104);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(134, 21);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email adressiniz:";
            // 
            // pcr_Back
            // 
            this.pcr_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcr_Back.BackgroundImage")));
            this.pcr_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcr_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Back.Location = new System.Drawing.Point(12, 12);
            this.pcr_Back.Name = "pcr_Back";
            this.pcr_Back.Size = new System.Drawing.Size(27, 23);
            this.pcr_Back.TabIndex = 21;
            this.pcr_Back.TabStop = false;
            this.pcr_Back.Click += new System.EventHandler(this.pcr_Back_Click);
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
            // IForgetMyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.pcr_Exit);
            this.Controls.Add(this.pcr_Back);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UaerName);
            this.Controls.Add(this.btn_SendAnEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IForgetMyPassword";
            this.Text = "IForgetMyPassword";
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendAnEmail;
        private System.Windows.Forms.Label lbl_UaerName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.PictureBox pcr_Back;
        private System.Windows.Forms.PictureBox pcr_Exit;
    }
}