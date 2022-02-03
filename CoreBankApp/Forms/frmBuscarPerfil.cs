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
    public partial class frmBuscarPerfil : Form
    {
        public frmBuscarPerfil()
        {
            InitializeComponent();
        }

        private void frmBuscarPerfil_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            buscarPerfil.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BPerfil.rdlc";
            RelacionClientePerfilTableAdapter adapter = new RelacionClientePerfilTableAdapter();
            RelacionClientePerfilDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
            buscarPerfil.LocalReport.DataSources.Clear();
            buscarPerfil.LocalReport.DataSources.Add(rds);

            this.buscarPerfil.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RelacionClientePerfilTableAdapter adapter = new RelacionClientePerfilTableAdapter();
            RelacionClientePerfilDataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
            buscarPerfil.LocalReport.DataSources.Clear();
            buscarPerfil.LocalReport.DataSources.Add(rds);

            this.buscarPerfil.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            RelacionClientePerfilTableAdapter adapter = new RelacionClientePerfilTableAdapter();
            RelacionClientePerfilDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
            buscarPerfil.LocalReport.DataSources.Clear();
            buscarPerfil.LocalReport.DataSources.Add(rds);

            this.buscarPerfil.RefreshReport();
        }
    }
}
