using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelStuff
{
  
    public partial class frmExcelAnalysis : Form
    {
        private List<ScriptBuySell> _scriptBuySell;
        public frmExcelAnalysis()
        {
            InitializeComponent();
        }

        private void cmdProessData_Click(object sender, EventArgs e)
        {

        }

        private void cmdLoadExcel_Click(object sender, EventArgs e)
        {
            //DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            //if (result == DialogResult.OK) // Test result.
            //{
            //    string file = openFileDialog.FileName;
            //    openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //    try
            //    {
            //        string text = File.ReadAllText(file);

            //    }
            //    catch (IOException ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
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
    }
}
