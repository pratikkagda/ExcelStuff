using System;
using System.Windows.Forms;

namespace ExcelStuff
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void cmdSignalAnalysis_Click(object sender, EventArgs e)
        {
            var frmSignalAlaysis = new frmSignalAnalysis();
            frmSignalAlaysis.Show();
        }
    }
}
