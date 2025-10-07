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
            this.btnBackRadio.Location = new System.Drawing.Point(693, 501);
            this.btnBackRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackRadio.Name = "btnBackRadio";
            this.btnBackRadio.Size = new System.Drawing.Size(100, 28);
            this.btnBackRadio.TabIndex = 1;
            this.btnBackRadio.Text = "Back";
            this.btnBackRadio.UseVisualStyleBackColor = true;
            this.btnBackRadio.Click += new System.EventHandler(this.btnBackRadio_Click);
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.btnBackRadio);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuiz";
            this.Text = "frmQuiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackRadio;
    }
}