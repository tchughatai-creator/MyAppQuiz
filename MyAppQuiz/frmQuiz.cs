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
    public partial class frmQuiz : Form
    {
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnBackRadio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
        }

        private void btnCalc_Click(object sender, EventArgs e)
            {
            double A, i, P;
            int n;

            // reading valeus
            A = Convert.ToDouble(txtA.Text);
            n = Convert.ToInt32(txtN.Text);
            i = Convert.ToDouble(txtInt.Text) / 100;

            // present worth
       
            P = A * ((Math.Pow(1 + i, n) - 1) / (i * (1 + i)));
            // result
            lblResult.Text = "Present Worth = " + P.ToString("F2");
        }

            private void btnBack_Click(object sender, EventArgs e)
            {
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
        }
    }





      
    

