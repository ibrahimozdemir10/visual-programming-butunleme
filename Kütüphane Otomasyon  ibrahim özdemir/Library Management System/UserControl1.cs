using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if(txtadmin_user.Text == "Username")
            {
                txtadmin_user.Text = "";
                txtadmin_user.ForeColor = Color.Silver;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (txtadmin_user.Text == "Password")
            {
                txtadmin_user.Text = "";
                txtadmin_user.ForeColor = Color.Silver;
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (txtadmin_user.Text == "")
            {
                txtadmin_user.Text = "Password";
                txtadmin_user.ForeColor = Color.Silver;
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txtadmin_user.Text == "")
            {
                txtadmin_user.Text = "Username";
                txtadmin_user.ForeColor = Color.Silver;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (txtadmin_user.Text == "ibrahim" && txtadmin_pass.Text == "1234")           
            {
                Form2 ff = new Form2();
                ff.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre! \n Lütfen Doğru Kullanıcı Adı ve Şifreyi Giriniz...");
            }
        }
    }
}
