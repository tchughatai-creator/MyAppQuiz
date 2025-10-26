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
    public partial class frmCalculations : Form
    {
        public frmCalculations()
        {
            InitializeComponent();
        }

        private void frmCalculations_Load(object sender, EventArgs e)
        {
            // يمكنك وضع أي كود تريده أن يعمل عند فتح الفورم هنا
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void txtboxNum2_TextChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void radiobtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void radiobtnSub_CheckedChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void radiobtnMulti_CheckedChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void radiobtnDev_CheckedChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void txtboxNum1_TextChanged(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void lblFirstnum_Click(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        private void lblSecondnum_Click(object sender, EventArgs e)
        {
            // اتركه فارغاً إذا لم تكن بحاجة إليه
        }

        // *** هنا الكود المهم لزر "احسب" ***
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double result = 0;

            // 1. التحقق من الرقم الأول والحصول عليه من (txtboxNum1)
            if (!double.TryParse(txtboxNum1.Text, out num1))
            {
                MessageBox.Show("Please enter a valid first number.");
                return; // إيقاف الكود
            }

            // 2. التحقق من الرقم الثاني والحصول عليه من (txtboxNum2)
            if (!double.TryParse(txtboxNum2.Text, out num2))
            {
                MessageBox.Show("Please enter a valid second number.");
                return; // إيقاف الكود
            }

            // 3. التحقق من أي (RadioButton) تم اختياره وتنفيذ العملية
            if (radiobtnAdd.Checked)
            {
                result = num1 + num2;
                MessageBox.Show($"The result of addition is: {result}");
            }
            else if (radiobtnSub.Checked)
            {
                result = num1 - num2;
                MessageBox.Show($"The result of subtraction is: {result}");
            }
            else if (radiobtnMulti.Checked)
            {
                result = num1 * num2;
                MessageBox.Show($"The result of multiplication is: {result}");
            }
            else if (radiobtnDev.Checked)
            {
                // حالة خاصة: منع القسمة على صفر
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
                else
                {
                    result = num1 / num2;
                    MessageBox.Show($"The result of division is: {result}");
                }
            }
            else
            {
                // في حال لم يتم اختيار أي شيء
                MessageBox.Show("Please select an operation.");
            }
        }

        // *** هنا الكود المهم لزر "رجوع" ***
        private void btnBack_Click(object sender, EventArgs e)
        {
            // إغلاق الفورم الحالي (frmCalculations)
            this.Close();
        }
    }
}
