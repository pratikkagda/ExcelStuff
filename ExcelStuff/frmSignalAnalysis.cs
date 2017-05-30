using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Generic;

namespace ExcelStuff
{
    public partial class frmSignalAnalysis : Form
    {
        private List<ScriptBuySell> _scriptBuySell;

        public string FileName { get; set; }

        public DataTable ExcelData { get; set; }
        public frmSignalAnalysis()
        {
            InitializeComponent();
            dvOrigianlExcel.Visible = false;
            label1.Visible = false;
        }

        private void cmdProcessFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                FileName = openFileDialog.FileName;
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                try
                {
                    //string text = File.ReadAllText(file);

                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                ExcelData = ConvertExcelToDataTable(openFileDialog.FileName);
                label1.Visible = dvOrigianlExcel.Visible = true;
                dvOrigianlExcel.DataSource = ExcelData;
                dvOrigianlExcel.AutoResizeColumns(
                DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                dvOrigianlExcel.AutoResizeRow(1, DataGridViewAutoSizeRowMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while processing excel sheet, error message:  " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static DataTable ConvertExcelToDataTable(string FileName)
        {
            DataTable dtResult = null;
            int totalSheet = 0; //No of sheets on excel file
            try
            {
                using (OleDbConnection objConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FileName + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';"))
                {
                    objConn.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    OleDbDataAdapter oleda = new OleDbDataAdapter();
                    DataSet ds = new DataSet();
                    DataTable dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetName = string.Empty;
                    if (dt != null)
                    {
                        var tempDataTable = (from dataRow in dt.AsEnumerable()
                                             where !dataRow["TABLE_NAME"].ToString().Contains("FilterDatabase")
                                             select dataRow).CopyToDataTable();
                        dt = tempDataTable;
                        totalSheet = dt.Rows.Count;
                        sheetName = dt.Rows[0]["TABLE_NAME"].ToString();
                    }
                    cmd.Connection = objConn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                    oleda = new OleDbDataAdapter(cmd);
                    oleda.Fill(ds, "excelData");
                    dtResult = ds.Tables["excelData"];
                    objConn.Close();
                    return dtResult; //Returning Dattable  
                }
            }
            catch
            {
                throw;
            }
        }

        private void cmdProcessData_Click(object sender, EventArgs e)
        {
            ExcelData.Columns[5].ColumnName = "Buy/Sell";
            _scriptBuySell = new List<ScriptBuySell>();

            foreach (DataRow row in ExcelData.Rows)
            {
                string scriptName = row["ScripName"].ToString();

                if (_scriptBuySell.Exists(c => c.ScriptName == scriptName))
                {
                    _scriptBuySell.FirstOrDefault(c => c.ScriptName == scriptName).IsBuy = row["SigCrossOver_Sell"].ToString().ToLower().Equals("buy") ? true : false;
                }
                else
                {
                    _scriptBuySell.Add(new ScriptBuySell
                    {
                        ScriptName = scriptName,
                        IsBuy = row["SigCrossOver_Sell"].ToString().ToLower().Equals("buy") ? true : false
                    });
                }

                row["Buy/Sell"] = _scriptBuySell.FirstOrDefault(s => s.ScriptName == scriptName).IsBuy ? "2-Sell" : "2-Buy";
            }

            dvOrigianlExcel.DataSource = ExcelData;
        }
    }
}
