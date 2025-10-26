namespace MyAppQuiz
{
    partial class frmCalculations
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtnAdd = new System.Windows.Forms.RadioButton();
            this.grpBoxRadioBtns = new System.Windows.Forms.GroupBox();
            this.radiobtnSub = new System.Windows.Forms.RadioButton();
            this.radiobtnMulti = new System.Windows.Forms.RadioButton();
            this.radiobtnDev = new System.Windows.Forms.RadioButton();
            this.txtboxNum1 = new System.Windows.Forms.TextBox();
            this.txtboxNum2 = new System.Windows.Forms.TextBox();
            this.lblFirstnum = new System.Windows.Forms.Label();
            this.lblSecondnum = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpBoxRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose one opreation only";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter numbers";
            // 
            // radiobtnAdd
            // 
            this.radiobtnAdd.AutoSize = true;
            this.radiobtnAdd.Location = new System.Drawing.Point(2, 19);
            this.radiobtnAdd.Name = "radiobtnAdd";
            this.radiobtnAdd.Size = new System.Drawing.Size(63, 17);
            this.radiobtnAdd.TabIndex = 11;
            this.radiobtnAdd.TabStop = true;
            this.radiobtnAdd.Text = "Addition";
            this.radiobtnAdd.UseVisualStyleBackColor = true;
            this.radiobtnAdd.CheckedChanged += new System.EventHandler(this.radiobtnAdd_CheckedChanged);
            // 
            // grpBoxRadioBtns
            // 
            this.grpBoxRadioBtns.Controls.Add(this.radiobtnDev);
            this.grpBoxRadioBtns.Controls.Add(this.radiobtnMulti);
            this.grpBoxRadioBtns.Controls.Add(this.radiobtnSub);
            this.grpBoxRadioBtns.Controls.Add(this.radiobtnAdd);
            this.grpBoxRadioBtns.Location = new System.Drawing.Point(15, 37);
            this.grpBoxRadioBtns.Name = "grpBoxRadioBtns";
            this.grpBoxRadioBtns.Size = new System.Drawing.Size(194, 62);
            this.grpBoxRadioBtns.TabIndex = 12;
            this.grpBoxRadioBtns.TabStop = false;
            this.grpBoxRadioBtns.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radiobtnSub
            // 
            this.radiobtnSub.AutoSize = true;
            this.radiobtnSub.Location = new System.Drawing.Point(103, 19);
            this.radiobtnSub.Name = "radiobtnSub";
            this.radiobtnSub.Size = new System.Drawing.Size(65, 17);
            this.radiobtnSub.TabIndex = 12;
            this.radiobtnSub.TabStop = true;
            this.radiobtnSub.Text = "Subtract";
            this.radiobtnSub.UseVisualStyleBackColor = true;
            this.radiobtnSub.CheckedChanged += new System.EventHandler(this.radiobtnSub_CheckedChanged);
            // 
            // radiobtnMulti
            // 
            this.radiobtnMulti.AutoSize = true;
            this.radiobtnMulti.Location = new System.Drawing.Point(2, 39);
            this.radiobtnMulti.Name = "radiobtnMulti";
            this.radiobtnMulti.Size = new System.Drawing.Size(60, 17);
            this.radiobtnMulti.TabIndex = 13;
            this.radiobtnMulti.TabStop = true;
            this.radiobtnMulti.Text = "Multiply";
            this.radiobtnMulti.UseVisualStyleBackColor = true;
            this.radiobtnMulti.CheckedChanged += new System.EventHandler(this.radiobtnMulti_CheckedChanged);
            // 
            // radiobtnDev
            // 
            this.radiobtnDev.AutoSize = true;
            this.radiobtnDev.Location = new System.Drawing.Point(103, 39);
            this.radiobtnDev.Name = "radiobtnDev";
            this.radiobtnDev.Size = new System.Drawing.Size(66, 17);
            this.radiobtnDev.TabIndex = 14;
            this.radiobtnDev.TabStop = true;
            this.radiobtnDev.Text = "Devision";
            this.radiobtnDev.UseVisualStyleBackColor = true;
            this.radiobtnDev.CheckedChanged += new System.EventHandler(this.radiobtnDev_CheckedChanged);
            // 
            // txtboxNum1
            // 
            this.txtboxNum1.Location = new System.Drawing.Point(109, 140);
            this.txtboxNum1.Name = "txtboxNum1";
            this.txtboxNum1.Size = new System.Drawing.Size(100, 20);
            this.txtboxNum1.TabIndex = 13;
            this.txtboxNum1.TextChanged += new System.EventHandler(this.txtboxNum1_TextChanged);
            // 
            // txtboxNum2
            // 
            this.txtboxNum2.Location = new System.Drawing.Point(109, 166);
            this.txtboxNum2.Name = "txtboxNum2";
            this.txtboxNum2.Size = new System.Drawing.Size(100, 20);
            this.txtboxNum2.TabIndex = 14;
            this.txtboxNum2.TextChanged += new System.EventHandler(this.txtboxNum2_TextChanged);
            // 
            // lblFirstnum
            // 
            this.lblFirstnum.AutoSize = true;
            this.lblFirstnum.Location = new System.Drawing.Point(14, 143);
            this.lblFirstnum.Name = "lblFirstnum";
            this.lblFirstnum.Size = new System.Drawing.Size(66, 13);
            this.lblFirstnum.TabIndex = 15;
            this.lblFirstnum.Text = "First Number";
            this.lblFirstnum.Click += new System.EventHandler(this.lblFirstnum_Click);
            // 
            // lblSecondnum
            // 
            this.lblSecondnum.AutoSize = true;
            this.lblSecondnum.Location = new System.Drawing.Point(14, 169);
            this.lblSecondnum.Name = "lblSecondnum";
            this.lblSecondnum.Size = new System.Drawing.Size(84, 13);
            this.lblSecondnum.TabIndex = 16;
            this.lblSecondnum.Text = "Second Number";
            this.lblSecondnum.Click += new System.EventHandler(this.lblSecondnum_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(17, 198);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 17;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(257, 233);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 268);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblSecondnum);
            this.Controls.Add(this.lblFirstnum);
            this.Controls.Add(this.txtboxNum2);
            this.Controls.Add(this.txtboxNum1);
            this.Controls.Add(this.grpBoxRadioBtns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculations";
            this.Text = "frmCalculations";
            this.Load += new System.EventHandler(this.frmCalculations_Load);
            this.grpBoxRadioBtns.ResumeLayout(false);
            this.grpBoxRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtnAdd;
        private System.Windows.Forms.GroupBox grpBoxRadioBtns;
        private System.Windows.Forms.RadioButton radiobtnDev;
        private System.Windows.Forms.RadioButton radiobtnMulti;
        private System.Windows.Forms.RadioButton radiobtnSub;
        private System.Windows.Forms.TextBox txtboxNum1;
        private System.Windows.Forms.TextBox txtboxNum2;
        private System.Windows.Forms.Label lblFirstnum;
        private System.Windows.Forms.Label lblSecondnum;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnBack;
    }
}