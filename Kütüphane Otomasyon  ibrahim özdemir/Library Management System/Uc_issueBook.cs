using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Uc_issueBook : UserControl
    {
        public Uc_issueBook()
        {
            InitializeComponent();
        }

        private void std_save_Click(object sender, EventArgs e)
        {
            string issue_book = stdName.Text + "," + stdId.Text + "," + BookName.Text + "," + arthrName.Text + "," + issueDate.Text;
            StreamWriter book_issueDeatil = new StreamWriter("BookIssueRec.txt", append: true);
            book_issueDeatil.WriteLine(issue_book);
            MessageBox.Show("Başarıyla Kitap Ödünç Alındı!..");
            stdName.Clear();
            stdId.Clear();
            BookName.Clear();
            arthrName.Clear();
            issueDate.Clear();
            book_issueDeatil.Close();


        }
    }
}
