namespace MyAppQuiz
{
    partial class frmQuiz
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
            this.SuspendLayout();
            // 
            // btnBackRadio
            // 
            this.btnBackRadio.Location = new System.Drawing.Point(520, 407);
            this.btnBackRadio.Name = "btnBackRadio";
            this.btnBackRadio.Size = new System.Drawing.Size(75, 23);
            this.btnBackRadio.TabIndex = 1;
            this.btnBackRadio.Text = "Back";
            this.btnBackRadio.UseVisualStyleBackColor = true;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 442);
            this.Controls.Add(this.btnBackRadio);
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackRadio;
    }
}