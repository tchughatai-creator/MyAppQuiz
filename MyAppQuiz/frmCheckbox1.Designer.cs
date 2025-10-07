namespace MyAppQuiz
{
    partial class FrmCheckbox1
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
            this.btnBackRadio = new System.Windows.Forms.Button();
            this.GrpQuestion = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.ChkJavascript = new System.Windows.Forms.CheckBox();
            this.ChkJava = new System.Windows.Forms.CheckBox();
            this.ChkPython = new System.Windows.Forms.CheckBox();
            this.ChkCsharp = new System.Windows.Forms.CheckBox();
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.chkBrownie = new System.Windows.Forms.CheckBox();
            this.chkDonut = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.btnShowSelected = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GrpQuestion.SuspendLayout();
            this.pnlCheckBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackRadio
            // 
            this.btnBackRadio.Location = new System.Drawing.Point(713, 415);
            this.btnBackRadio.Name = "btnBackRadio";
            this.btnBackRadio.Size = new System.Drawing.Size(75, 23);
            this.btnBackRadio.TabIndex = 1;
            this.btnBackRadio.Text = "Back";
            this.btnBackRadio.UseVisualStyleBackColor = true;
            this.btnBackRadio.Click += new System.EventHandler(this.btnBackRadio_Click);
            // 
            // GrpQuestion
            // 
            this.GrpQuestion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GrpQuestion.Controls.Add(this.BtnSubmit);
            this.GrpQuestion.Controls.Add(this.LblQuestion);
            this.GrpQuestion.Controls.Add(this.ChkJavascript);
            this.GrpQuestion.Controls.Add(this.ChkJava);
            this.GrpQuestion.Controls.Add(this.ChkPython);
            this.GrpQuestion.Controls.Add(this.ChkCsharp);
            this.GrpQuestion.Location = new System.Drawing.Point(153, 12);
            this.GrpQuestion.Name = "GrpQuestion";
            this.GrpQuestion.Size = new System.Drawing.Size(342, 176);
            this.GrpQuestion.TabIndex = 9;
            this.GrpQuestion.TabStop = false;
            this.GrpQuestion.Text = "Question";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.Location = new System.Drawing.Point(69, 145);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(79, 25);
            this.BtnSubmit.TabIndex = 5;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblQuestion
            // 
            this.LblQuestion.AutoSize = true;
            this.LblQuestion.Location = new System.Drawing.Point(11, 16);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(329, 13);
            this.LblQuestion.TabIndex = 4;
            this.LblQuestion.Text = "In which programming languages, you can solve any given problem?";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ChkJavascript
            // 
            this.ChkJavascript.AutoSize = true;
            this.ChkJavascript.Location = new System.Drawing.Point(6, 122);
            this.ChkJavascript.Name = "ChkJavascript";
            this.ChkJavascript.Size = new System.Drawing.Size(74, 17);
            this.ChkJavascript.TabIndex = 3;
            this.ChkJavascript.Text = "Javascript";
            this.ChkJavascript.UseVisualStyleBackColor = true;
            // 
            // ChkJava
            // 
            this.ChkJava.AutoSize = true;
            this.ChkJava.Location = new System.Drawing.Point(6, 98);
            this.ChkJava.Name = "ChkJava";
            this.ChkJava.Size = new System.Drawing.Size(49, 17);
            this.ChkJava.TabIndex = 2;
            this.ChkJava.Text = "Java";
            this.ChkJava.UseVisualStyleBackColor = true;
            // 
            // ChkPython
            // 
            this.ChkPython.AutoSize = true;
            this.ChkPython.Location = new System.Drawing.Point(6, 75);
            this.ChkPython.Name = "ChkPython";
            this.ChkPython.Size = new System.Drawing.Size(59, 17);
            this.ChkPython.TabIndex = 1;
            this.ChkPython.Text = "Python";
            this.ChkPython.UseVisualStyleBackColor = true;
            // 
            // ChkCsharp
            // 
            this.ChkCsharp.AutoSize = true;
            this.ChkCsharp.Location = new System.Drawing.Point(6, 52);
            this.ChkCsharp.Name = "ChkCsharp";
            this.ChkCsharp.Size = new System.Drawing.Size(40, 17);
            this.ChkCsharp.TabIndex = 0;
            this.ChkCsharp.Text = "C#";
            this.ChkCsharp.UseVisualStyleBackColor = true;
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.Controls.Add(this.chkBrownie);
            this.pnlCheckBoxes.Controls.Add(this.chkDonut);
            this.pnlCheckBoxes.Controls.Add(this.chkCoffee);
            this.pnlCheckBoxes.Location = new System.Drawing.Point(11, 12);
            this.pnlCheckBoxes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(102, 81);
            this.pnlCheckBoxes.TabIndex = 8;
            // 
            // chkBrownie
            // 
            this.chkBrownie.AutoSize = true;
            this.chkBrownie.Location = new System.Drawing.Point(11, 57);
            this.chkBrownie.Name = "chkBrownie";
            this.chkBrownie.Size = new System.Drawing.Size(64, 17);
            this.chkBrownie.TabIndex = 7;
            this.chkBrownie.Text = "Brownie";
            this.chkBrownie.UseVisualStyleBackColor = true;
            // 
            // chkDonut
            // 
            this.chkDonut.AutoSize = true;
            this.chkDonut.Location = new System.Drawing.Point(11, 34);
            this.chkDonut.Name = "chkDonut";
            this.chkDonut.Size = new System.Drawing.Size(55, 17);
            this.chkDonut.TabIndex = 6;
            this.chkDonut.Text = "Donut";
            this.chkDonut.UseVisualStyleBackColor = true;
            this.chkDonut.CheckedChanged += new System.EventHandler(this.chkDonut_CheckedChanged);
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(11, 11);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(57, 17);
            this.chkCoffee.TabIndex = 5;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // btnShowSelected
            // 
            this.btnShowSelected.Location = new System.Drawing.Point(12, 110);
            this.btnShowSelected.Name = "btnShowSelected";
            this.btnShowSelected.Size = new System.Drawing.Size(75, 23);
            this.btnShowSelected.TabIndex = 7;
            this.btnShowSelected.Text = "Show ";
            this.btnShowSelected.UseVisualStyleBackColor = true;
            this.btnShowSelected.Click += new System.EventHandler(this.btnShowSelected_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCheckbox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 239);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrpQuestion);
            this.Controls.Add(this.pnlCheckBoxes);
            this.Controls.Add(this.btnShowSelected);
            this.Controls.Add(this.btnBackRadio);
            this.Name = "FrmCheckbox1";
            this.Text = "frmCheckbox1";
            this.GrpQuestion.ResumeLayout(false);
            this.GrpQuestion.PerformLayout();
            this.pnlCheckBoxes.ResumeLayout(false);
            this.pnlCheckBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackRadio;
        private System.Windows.Forms.GroupBox GrpQuestion;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.CheckBox ChkJavascript;
        private System.Windows.Forms.CheckBox ChkJava;
        private System.Windows.Forms.CheckBox ChkPython;
        private System.Windows.Forms.CheckBox ChkCsharp;
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.CheckBox chkBrownie;
        private System.Windows.Forms.CheckBox chkDonut;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.Button btnShowSelected;
        private System.Windows.Forms.Button button1;
    }
}