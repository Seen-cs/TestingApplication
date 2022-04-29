using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace WinFormsUI
{
    public partial class IForgetMyPassword : Form
    {
        public IForgetMyPassword()
        {
            InitializeComponent();
        }
        UserManager userManager = new UserManager(new EfUserDal());
        private void btn_SendAnEmail_Click(object sender, EventArgs e)
        {
            
            if (userManager.GetUserWithUserNameAndEmail(txt_UserName.Text, txt_Email.Text).Success==false)
            {
                MessageBox.Show("Kullanıcı ve email eşleşmiyor! tekrar deneyin");
            }

            else
            {
                //Random random = new Random();
                //int newPassword = random.Next(1000, 9999);
                MailMessage eMail = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("seen.cs@outlook.com", "42534253S.");
                smtp.Port = 587;
                smtp.Host= "smtp.live.com";
                smtp.EnableSsl = true;
                eMail.To.Add(userManager.GetUserWithUserNameAndEmail(txt_UserName.Text, txt_Email.Text).Data.Mail);
                eMail.From = new MailAddress("seen.cs@outlook.com");
                eMail.Subject = "Testing Application Parola Yenileme";
                eMail.Attachments.Add(new Attachment(@"C:\Users\Enes\Desktop\Project\C#\TestingApplication\Data\TESTTING APPLİCATİON.gif"));
                eMail.Body = $"\tMerhaba,\n\nUygulamayı kullanmya devam edebilmek için şifreniz: {userManager.GetUserWithUserNameAndEmail(txt_UserName.Text, txt_Email.Text).Data.Password}";
                smtp.Send(eMail);
                //var temp = userManager.GetUserWithUserNameAndEmail(txt_UserName.Text, txt_Email.Text).Data;
                //temp.Password = newPassword.ToString();
                //userManager.Update(temp);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            
            
        }

    }
}
