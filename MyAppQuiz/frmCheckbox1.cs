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
    public partial class FrmCheckbox1 : Form
    {
        public FrmCheckbox1()
        {
            InitializeComponent();
        }

        private void btnBackRadio_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void chkDonut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnShowSelected_Click(object sender, EventArgs e)
        {

            string msg = "";
            if (chkCoffee.Checked == true)
            {
                msg = chkCoffee.Text;
            }

            if (chkDonut.Checked == true)
            {
                msg = msg + " " + chkDonut.Text;
            }

            if (chkBrownie.Checked == true)
            {
                msg = msg + " " + chkBrownie.Text;
            }



            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " selected ");
            }
            else //length is zero
            {
                MessageBox.Show("Nothing selected");
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Check the selected checkboxes and provide feedback
            string result = "Your selected options: ";
            foreach (Control ctrl in GrpQuestion.Controls)
            {
                if (ctrl is CheckBox checkBox && checkBox.Checked)
                {
                    result += checkBox.Text + ", ";
                }
            }

            if (result == "Your selected options: ")
            {
                result += "None"; // No checkboxes were selected
            }
            else
            {
                result = result.TrimEnd(',', ' '); // Remove the trailing comma and space
            }

            MessageBox.Show(result, "Your Selection");

        }

        private void FrmCheckbox1_Load(object sender, EventArgs e)
        {

        }
    }
}
