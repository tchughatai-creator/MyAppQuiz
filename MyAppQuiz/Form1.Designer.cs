namespace MyAppQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblIE = new System.Windows.Forms.Label();
            this.lblKAU = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblForgot = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckbox = new System.Windows.Forms.Button();
            this.btnRadio = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.StatusStrip();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(140)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(26, 300);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 42);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.panelSidebar.Controls.Add(this.btnAbout);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Controls.Add(this.lblForgot);
            this.panelSidebar.Controls.Add(this.txtUser);
            this.panelSidebar.Controls.Add(this.lblKAU);
            this.panelSidebar.Controls.Add(this.lblIE);
            this.panelSidebar.Controls.Add(this.btnLogin);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(320, 581);
            this.panelSidebar.TabIndex = 2;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIE.ForeColor = System.Drawing.Color.White;
            this.lblIE.Location = new System.Drawing.Point(26, 22);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(75, 71);
            this.lblIE.TabIndex = 0;
            this.lblIE.Text = "IE";
            this.lblIE.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblKAU
            // 
            this.lblKAU.AutoSize = true;
            this.lblKAU.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKAU.ForeColor = System.Drawing.Color.White;
            this.lblKAU.Location = new System.Drawing.Point(26, 79);
            this.lblKAU.Name = "lblKAU";
            this.lblKAU.Size = new System.Drawing.Size(138, 71);
            this.lblKAU.TabIndex = 1;
            this.lblKAU.Text = "KAU";
            this.lblKAU.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(26, 150);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(59, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(76)))), ((int)(((byte)(130)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(26, 245);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(26, 175);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(260, 20);
            this.txtUser.TabIndex = 6;
            // 
            // lblForgot
            // 
            this.lblForgot.BackColor = System.Drawing.Color.Transparent;
            this.lblForgot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.LightGray;
            this.lblForgot.Location = new System.Drawing.Point(26, 271);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(115, 24);
            this.lblForgot.TabIndex = 6;
            this.lblForgot.Text = "Forgot Password";
            this.lblForgot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblForgot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.lblForgot.UseVisualStyleBackColor = false;
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(140)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.No;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(26, 504);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 42);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.toolStripStatusLabel1);
            this.panelRight.Controls.Add(this.groupBox1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRight.Location = new System.Drawing.Point(320, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(20);
            this.panelRight.Size = new System.Drawing.Size(664, 581);
            this.panelRight.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuiz);
            this.groupBox1.Controls.Add(this.btnRadio);
            this.groupBox1.Controls.Add(this.btnCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(40, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Components";
            // 
            // btnCheckbox
            // 
            this.btnCheckbox.Location = new System.Drawing.Point(40, 110);
            this.btnCheckbox.Name = "btnCheckbox";
            this.btnCheckbox.Size = new System.Drawing.Size(520, 60);
            this.btnCheckbox.TabIndex = 0;
            this.btnCheckbox.Text = "Checkbox";
            this.btnCheckbox.UseVisualStyleBackColor = true;
            this.btnCheckbox.Click += new System.EventHandler(this.btnOpencheckbox_Click);
            // 
            // btnRadio
            // 
            this.btnRadio.Location = new System.Drawing.Point(40, 190);
            this.btnRadio.Name = "btnRadio";
            this.btnRadio.Size = new System.Drawing.Size(520, 60);
            this.btnRadio.TabIndex = 1;
            this.btnRadio.Text = "Radio";
            this.btnRadio.UseVisualStyleBackColor = true;
            this.btnRadio.Click += new System.EventHandler(this.btnRadio_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(20, 539);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(624, 22);
            this.toolStripStatusLabel1.TabIndex = 1;
            this.toolStripStatusLabel1.Text = "statusStrip1";
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(40, 270);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(520, 60);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Extra";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.LightGray;
            this.btnAbout.Location = new System.Drawing.Point(26, 348);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(115, 24);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.Label lblKAU;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button lblForgot;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRadio;
        private System.Windows.Forms.Button btnCheckbox;
        private System.Windows.Forms.StatusStrip toolStripStatusLabel1;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Button btnAbout;
    }
}

