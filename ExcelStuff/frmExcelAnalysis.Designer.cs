namespace ExcelStuff
{
    partial class frmExcelAnalysis
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
            this.cmdLoadExcel = new System.Windows.Forms.Button();
            this.dgvOrigianlExcel = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdProessData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigianlExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLoadExcel
            // 
            this.cmdLoadExcel.Location = new System.Drawing.Point(60, 33);
            this.cmdLoadExcel.Name = "cmdLoadExcel";
            this.cmdLoadExcel.Size = new System.Drawing.Size(103, 34);
            this.cmdLoadExcel.TabIndex = 0;
            this.cmdLoadExcel.Text = "Load Excel Sheet";
            this.cmdLoadExcel.UseVisualStyleBackColor = true;
            this.cmdLoadExcel.Click += new System.EventHandler(this.cmdLoadExcel_Click);
            // 
            // dgvOrigianlExcel
            // 
            this.dgvOrigianlExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigianlExcel.Location = new System.Drawing.Point(60, 122);
            this.dgvOrigianlExcel.Name = "dgvOrigianlExcel";
            this.dgvOrigianlExcel.Size = new System.Drawing.Size(240, 150);
            this.dgvOrigianlExcel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origianl Excel Sheet:";
            // 
            // cmdProessData
            // 
            this.cmdProessData.Location = new System.Drawing.Point(215, 33);
            this.cmdProessData.Name = "cmdProessData";
            this.cmdProessData.Size = new System.Drawing.Size(103, 34);
            this.cmdProessData.TabIndex = 3;
            this.cmdProessData.Text = "Process Data";
            this.cmdProessData.UseVisualStyleBackColor = true;
            this.cmdProessData.Click += new System.EventHandler(this.cmdProessData_Click);
            // 
            // frmExcelAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 322);
            this.Controls.Add(this.cmdProessData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrigianlExcel);
            this.Controls.Add(this.cmdLoadExcel);
            this.Name = "frmExcelAnalysis";
            this.Text = "Signal Analysis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigianlExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdLoadExcel;
        private System.Windows.Forms.DataGridView dgvOrigianlExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdProessData;
    }
}