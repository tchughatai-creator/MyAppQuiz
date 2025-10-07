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
    }
}
