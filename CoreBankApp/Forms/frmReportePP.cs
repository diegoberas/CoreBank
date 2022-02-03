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
    public partial class frmReportePP : Form
    {
        public frmReportePP()
        {
            InitializeComponent();
        }

        private void frmReportePP_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana

            reportePP.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\RepPP.rdlc";
            RelacionPPTableAdapter adapter = new RelacionPPTableAdapter();
            RelacionPPDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSPP", (DataTable)rcc);
            reportePP.LocalReport.DataSources.Clear();
            reportePP.LocalReport.DataSources.Add(rds);
            this.reportePP.RefreshReport();
        }
    }
}
