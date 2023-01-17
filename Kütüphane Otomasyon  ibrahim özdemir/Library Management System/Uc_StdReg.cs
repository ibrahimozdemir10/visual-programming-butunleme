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
    public partial class Uc_StdReg : UserControl
    {
        public Uc_StdReg()
        {
            InitializeComponent();
        }

        private void std_save_Click(object sender, EventArgs e)
        {
            string stdData = stdName.Text + "," + stdId.Text + "," + stdSem.Text + "," + stdDept.Text + "," + stdContact.Text;
            StreamWriter stdDetail = new StreamWriter("StudentRec.txt", append: true);
            stdDetail.WriteLine(stdData);
            MessageBox.Show("Başarıyla Kaydedildi..");
            stdName.Clear();
            stdId.Clear();
            stdSem.Clear();
            stdDept.Clear();
            stdContact.Clear();
            stdDetail.Close();
        }
    }
}
