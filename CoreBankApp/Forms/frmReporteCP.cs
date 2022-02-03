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
    public partial class frmReporteCP : Form
    {
        public frmReporteCP()
        {
            InitializeComponent();
        }

        private void frmReporteCP_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            reportCP.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\RepCP.rdlc";
            RelacionCPTableAdapter adapter = new RelacionCPTableAdapter();
            RelacionCPDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DScp", (DataTable)rcc);
            reportCP.LocalReport.DataSources.Clear();
            reportCP.LocalReport.DataSources.Add(rds);
            this.reportCP.RefreshReport();
        }
    }
}
