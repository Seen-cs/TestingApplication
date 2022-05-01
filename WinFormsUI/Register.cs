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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        UserManager userManager = new UserManager(new EfUserDal());
        private void button1_Click(object sender, EventArgs e)
        {

            if (userManager.GetUserWithUserNameAndPassword(textBox1.Text, textBox2.Text).Success)
            {
                MessageBox.Show("Bu kullanici zaten var.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Kullanıcı adı ve parola bos bırakılamaz");
                    Login login = new Login();
                    login.Show();
                    this.Hide();

                }
                else {
                    userManager.Add(new User { UserName = textBox1.Text, Password = textBox2.Text, UserTypeId = 3, LastLoginDate = DateTime.Now });
                    //kullanıcı kayıt olduktan sonra sınava yönlendirilmeli ilk gün kayıt oldugu gün sayılır
                    Test test = new Test()
                    {
                        userName = textBox1.Text.ToString(),
                        password = textBox2.Text.ToString()
                    };
                test.Show();
                this.Hide();
                }
            }
        }
    }
}
