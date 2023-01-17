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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uc_issueBook1.Hide();
            uc_returnBook1.Hide();
            uc_StatusCheck1.Hide();
            uc_StdReg1.Show();
            uc_StdReg1.BringToFront();
        }

        private void btn_issueBook_Click(object sender, EventArgs e)
        {
            uc_StdReg1.Hide();
            uc_returnBook1.Hide();
            uc_StatusCheck1.Hide();
            uc_issueBook1.Show();
            uc_issueBook1.BringToFront();
        }

        private void btn_checkStatus_Click(object sender, EventArgs e)
        {
            uc_StdReg1.Hide();
            uc_returnBook1.Hide();
            uc_issueBook1.Hide();
            uc_StatusCheck1.Show();
            uc_StatusCheck1.BringToFront();
        }

        private void btn_returnBook_Click(object sender, EventArgs e)
        {
            uc_StdReg1.Hide();
            uc_StatusCheck1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Show();
            uc_returnBook1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            uc_StdReg1.Hide();
            uc_StatusCheck1.Hide();
            uc_issueBook1.Hide();
            uc_returnBook1.Hide();
            
        }
    }
}
