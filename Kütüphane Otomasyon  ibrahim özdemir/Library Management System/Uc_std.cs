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
    public partial class Uc_std : UserControl
    {
        public Uc_std()
        {
            InitializeComponent();
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            if (txtstd_user.Text == "Username")
            {
                txtstd_user.Text = "";
                txtstd_user.ForeColor = Color.Silver;
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (txtstd_user.Text == "")
            {
                txtstd_user.Text = "Username";
                txtstd_user.ForeColor = Color.Silver;
            }
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (txtstd_pass.Text == "Password")
            {
                txtstd_pass.Text = "";
                txtstd_pass.ForeColor = Color.Silver;
            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (txtstd_pass.Text == "")
            {
                txtstd_pass.Text = "Password";
                txtstd_pass.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(txtstd_user.Text == "ibrahim" && txtstd_pass.Text == "1234")
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre!! \n Lütfen Doğru Kullanıcı Adı ve Şifreyi Giriniz...");
            }
        }

        private void Uc_std_Load(object sender, EventArgs e)
        {

        }
    }
}
