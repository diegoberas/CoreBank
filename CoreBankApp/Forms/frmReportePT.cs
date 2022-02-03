using CoreBankApp.DSCoreTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CoreBankApp.DSCore;

namespace CoreBankApp.Forms
{
    public partial class frmReportePT : Form
    {
        public frmReportePT()
        {
            InitializeComponent();
        }

        private void frmReportePT_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            reportPT.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\RepPT.rdlc";
            RelacionPTTableAdapter adapter = new RelacionPTTableAdapter();
            RelacionPTDataTable rcc = adapter.GetDataBy();
            ReportDataSource rds = new ReportDataSource("DSpt", (DataTable)rcc);
            reportPT.LocalReport.DataSources.Clear();
            reportPT.LocalReport.DataSources.Add(rds);
            this.reportPT.RefreshReport();
        }
    }
}
