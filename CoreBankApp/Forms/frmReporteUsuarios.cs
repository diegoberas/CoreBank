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
    public partial class frmReporteUsuarios : Form
    {
        public frmReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frmReporteUsuarios_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            string cliente = "cliente";
            reporteUsuarios.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\ReporteUsuario.rdlc";
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            tblUsuariosDataTable rcc = adapter.GetDataByCliente(cliente);
            ReportDataSource rds = new ReportDataSource("DSRU", (DataTable)rcc);
            reporteUsuarios.LocalReport.DataSources.Clear();
            reporteUsuarios.LocalReport.DataSources.Add(rds);

            this.reporteUsuarios.RefreshReport();
        }
    }
}
