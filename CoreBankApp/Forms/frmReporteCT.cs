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
    public partial class frmReporteCT : Form
    {
        public frmReporteCT()
        {
            InitializeComponent();
        }

        private void frmReporteCT_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            reportCT.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\RepCT.rdlc";
            RelacionCTTableAdapter adapter = new RelacionCTTableAdapter();
            RelacionCTDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSct", (DataTable)rcc);
            reportCT.LocalReport.DataSources.Clear();
            reportCT.LocalReport.DataSources.Add(rds);

            this.reportCT.RefreshReport();
        }
    }
}
