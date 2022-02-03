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
    public partial class frmReporteCuenta : Form
    {
        public frmReporteCuenta()
        {
            InitializeComponent();
        }

        private void frmReporteCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana

            reporteCuenta.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\ECuenta.rdlc";
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();
            tblCuentasDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSEcuenta", (DataTable)rcc);
            reporteCuenta.LocalReport.DataSources.Clear();
            reporteCuenta.LocalReport.DataSources.Add(rds);
            this.reporteCuenta.RefreshReport();
        }
    }
}
