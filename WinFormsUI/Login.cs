using Businiess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class Login : Form
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public Login()
        {
            InitializeComponent();
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            if (userManager.UserValidation(txt_UserName.Text.ToString(), txt_Password.Text.ToString()) == true)
            {
                var userType = userManager.GetUserWithUserNameAndPassword(txt_UserName.Text, txt_Password.Text).Data.UserTypeId;
                if (userType==2)
                {
                    TrainerPanel trainerPanel = new TrainerPanel();
                    trainerPanel.Show();
                    this.Hide();
                }
                if (userType == 1)
                {
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                    this.Hide();
                }
                if (userType == 3)
                {
                    Test test = new Test()
                    {
                        userName = txt_UserName.Text.ToString(),
                        password = txt_Password.Text.ToString()
                    };
                    test.Show();
                    this.Hide();
                }
                
            }
            else
                MessageBox.Show("Bu kullanıcı bulunamadı!");

        }

        private void llbl_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void llbl_IForgetMyPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IForgetMyPassword iforgetMyPassword = new IForgetMyPassword();
            iforgetMyPassword.Show();
            this.Hide();
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.ForeColor = Color.Green;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.ForeColor = Color.Black;
        }
    }
}
