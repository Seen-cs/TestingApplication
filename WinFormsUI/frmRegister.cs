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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        UserManager userManager = new UserManager(new EfUserDal());
        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (userManager.GetUserWithUserNameAndPassword(txt_UserName.Text, txt_Password.Text).Success)
            {
                MessageBox.Show("Bu kullanici zaten var.");
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            }
            else
            {
                if (txt_UserName.Text == "" || txt_Password.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı ve parola bos bırakılamaz");
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Hide();

                }
                else
                {
                    switch (cmbb_UserType.Text)
                    {
                        case "Öğrenci":
                        {
                               UserAdd(3);
                               frmTest test = new frmTest()
                               {
                                     userName = txt_UserName.Text.ToString(),
                                     password = txt_Password.Text.ToString()
                               };
                               test.Show();
                               this.Hide();
                               break;
                        }
                        case "Eğitmen":
                        {
                                UserAdd(2);
                                frmTrainerPanel trainerPanel = new frmTrainerPanel();
                                trainerPanel.Show();
                                this.Hide();
                                break;
                        }
                        case "Admin":
                        {
                                MessageBox.Show("Admin olarak kayıt olmaya yetkiniz yok seen.cs@outlook.com hesabına mail atabilir talebinizi iletebilirsiniz.");
                                break;
                        }
                        default:
                        {
                                MessageBox.Show("Lütfen kullanıcı tipi seçili olduğundan emin olun!");
                                break;
                        }


                    }
                    
                   
                    
                }
            }
        }

        private void UserAdd(int userTypeId)
        {
            userManager.Add(new User
            {
                UserName = txt_UserName.Text,
                Password = txt_Password.Text,
                UserTypeId = userTypeId,
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                Mail = txt_email.Text,
                SigmaPeriod1=1,
                SigmaPeriod2=7,
                SigmaPeriod3=30,
                SigmaPeriod4=90,
                SigmaPeriod5=365
                
            });
        }

        private void pcr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcr_Back_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btn_Register_MouseHover(object sender, EventArgs e)
        {
            btn_Register.ForeColor = Color.Yellow;
        }

        private void btn_Register_MouseLeave(object sender, EventArgs e)
        {
            btn_Register.ForeColor = Color.Black;
        }
    }
}
