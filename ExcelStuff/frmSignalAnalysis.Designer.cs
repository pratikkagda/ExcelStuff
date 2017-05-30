namespace ExcelStuff
{
    partial class frmSignalAnalysis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdProcessFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dvOrigianlExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdProcessData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOrigianlExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdProcessData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dvOrigianlExcel);
            this.panel1.Controls.Add(this.cmdProcessFile);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 373);
            this.panel1.TabIndex = 0;
            // 
            // cmdProcessFile
            // 
            this.cmdProcessFile.Location = new System.Drawing.Point(35, 22);
            this.cmdProcessFile.Name = "cmdProcessFile";
            this.cmdProcessFile.Size = new System.Drawing.Size(121, 37);
            this.cmdProcessFile.TabIndex = 1;
            this.cmdProcessFile.Text = "Load Excel Sheet";
            this.cmdProcessFile.UseVisualStyleBackColor = true;
            this.cmdProcessFile.Click += new System.EventHandler(this.cmdProcessFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "fileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // dvOrigianlExcel
            // 
            this.dvOrigianlExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvOrigianlExcel.Location = new System.Drawing.Point(35, 99);
            this.dvOrigianlExcel.Name = "dvOrigianlExcel";
            this.dvOrigianlExcel.Size = new System.Drawing.Size(391, 207);
            this.dvOrigianlExcel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Excel Sheet Data:";
            // 
            // cmdProcessData
            // 
            this.cmdProcessData.Location = new System.Drawing.Point(218, 22);
            this.cmdProcessData.Name = "cmdProcessData";
            this.cmdProcessData.Size = new System.Drawing.Size(121, 37);
            this.cmdProcessData.TabIndex = 4;
            this.cmdProcessData.Text = "Process Data";
            this.cmdProcessData.UseVisualStyleBackColor = true;
            this.cmdProcessData.Click += new System.EventHandler(this.cmdProcessData_Click);
            // 
            // frmSignalAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 398);
            this.Controls.Add(this.panel1);
            this.Name = "frmSignalAnalysis";
            this.Text = "Signal Analysis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvOrigianlExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cmdProcessFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvOrigianlExcel;
        private System.Windows.Forms.Button cmdProcessData;
    }
}