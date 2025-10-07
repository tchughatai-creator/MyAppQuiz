using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAppQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOpencheckbox_Click(object sender, EventArgs e)
        {
            FrmCheckbox1 frm = new FrmCheckbox1();
            frm.ShowDialog();





        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            FrmCheckbox1 frm = new FrmCheckbox1();
            frm.ShowDialog();
        }
    }
}
