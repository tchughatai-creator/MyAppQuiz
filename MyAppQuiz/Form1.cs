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
        string username = "taher";      
        string myPassword = "1234";    
        string msg = "You're logged in";

        bool loggedIn = false;

        int ThisAttempt = 1;
        int MaxAttempts = 3;
        public Form1()
        {
            InitializeComponent();
        }
    

            private void btnQuiz2_Click(object sender, EventArgs e)
            {
                frmQuiz q = new frmQuiz();
                q.Show();
                this.Hide();
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
            FrmRadio1 frm = new FrmRadio1();
            frm.ShowDialog();
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please try to remember your passwords");

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                while (ThisAttempt <= MaxAttempts)
                {
                    if (txtUser.Text != username)
                    {
                        // username is incorrect
                        msg = "Invalid username, " + (MaxAttempts - ThisAttempt) + " attempts remaining";
                        ThisAttempt++; //
                        break;
                    }
                    else
                    {   // username is correct
                        // so check password			
                        if (txtPassword.Text != myPassword)
                        {
                            // Incorrect password                            
                            msg = "Incorrect password," + (MaxAttempts - ThisAttempt) + " attempts remaining";
                            ThisAttempt++;
                            break;
                        }
                        else
                        {
                            //Both are correct
                            ThisAttempt = 1; // reset the number of attempts
                            loggedIn = true;
                            msg = "Hi " + username + ", your login successful";


                            foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                            {
                                foreach (var btn in grp.Controls.OfType<Button>())
                                {
                                    btn.Enabled = true;
                                    btn.ForeColor = Color.Black;
                                }
                            }

                            btnLogin.Text = "Logout";
                            toolStripStatusLabel1.Text = "Hi " + username + ", you are logged in.";
                            // this.Width = 1600;
                            break; // come out of while loop
                        }//endif

                    }//endif                    
                }//end while
                MessageBox.Show(msg);
                if (ThisAttempt > MaxAttempts)
                {
                    MessageBox.Show("Contact admin, closing app...");
                    Close();
                }
                msg = "";//reset msg 
            }
            else
            {
                btnLogin.Text = "Login";
                toolStripStatusLabel1.Text = "You are logged out.";
                loggedIn = false;

                txtUser.Clear();
                txtPassword.Clear();

                foreach (var grp in groupBox1.Controls.OfType<GroupBox>())
                {
                    foreach (var btn in grp.Controls.OfType<Button>())
                    {
                        btn.Enabled = false;
                    }
                }

            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {
            frmQuiz frm = new frmQuiz();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
