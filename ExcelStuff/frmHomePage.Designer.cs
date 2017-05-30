namespace ExcelStuff
{
    partial class frmHomePage
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
            this.cmdSignalAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSignalAnalysis
            // 
            this.cmdSignalAnalysis.Location = new System.Drawing.Point(82, 38);
            this.cmdSignalAnalysis.Name = "cmdSignalAnalysis";
            this.cmdSignalAnalysis.Size = new System.Drawing.Size(131, 35);
            this.cmdSignalAnalysis.TabIndex = 0;
            this.cmdSignalAnalysis.Text = "Signal Analysis";
            this.cmdSignalAnalysis.UseVisualStyleBackColor = true;
            this.cmdSignalAnalysis.Click += new System.EventHandler(this.cmdSignalAnalysis_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdSignalAnalysis);
            this.Name = "frmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Stuff";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSignalAnalysis;
    }
}

