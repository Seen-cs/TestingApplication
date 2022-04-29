
namespace WinFormsUI
{
    partial class IForgetMyPassword
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
            this.btn_SendAnEmail = new System.Windows.Forms.Button();
            this.lbl_UaerName = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SendAnEmail
            // 
            this.btn_SendAnEmail.Location = new System.Drawing.Point(336, 272);
            this.btn_SendAnEmail.Name = "btn_SendAnEmail";
            this.btn_SendAnEmail.Size = new System.Drawing.Size(153, 61);
            this.btn_SendAnEmail.TabIndex = 0;
            this.btn_SendAnEmail.Text = "Eposta Gönder";
            this.btn_SendAnEmail.UseVisualStyleBackColor = true;
            this.btn_SendAnEmail.Click += new System.EventHandler(this.btn_SendAnEmail_Click);
            // 
            // lbl_UaerName
            // 
            this.lbl_UaerName.AutoSize = true;
            this.lbl_UaerName.Location = new System.Drawing.Point(54, 103);
            this.lbl_UaerName.Name = "lbl_UaerName";
            this.lbl_UaerName.Size = new System.Drawing.Size(108, 20);
            this.lbl_UaerName.TabIndex = 1;
            this.lbl_UaerName.Text = "Kulanıcı adınız:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(193, 103);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(125, 27);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(193, 166);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(125, 27);
            this.txt_Email.TabIndex = 4;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(54, 173);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(118, 20);
            this.lbl_Email.TabIndex = 3;
            this.lbl_Email.Text = "Email adressiniz:";
            // 
            // IForgetMyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UaerName);
            this.Controls.Add(this.btn_SendAnEmail);
            this.Name = "IForgetMyPassword";
            this.Text = "IForgetMyPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SendAnEmail;
        private System.Windows.Forms.Label lbl_UaerName;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label lbl_Email;
    }
}