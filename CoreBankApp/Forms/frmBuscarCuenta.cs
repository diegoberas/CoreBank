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
    public partial class frmBuscarCuenta : Form
    {
        public frmBuscarCuenta()
        {
            InitializeComponent();
        }

        private void frmBuscarCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana

            buscarCuentas.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BuscarCuenta.rdlc";
            RelacionClienteCuentaTableAdapter adapter = new RelacionClienteCuentaTableAdapter();
            RelacionClienteCuentaDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSRCC", (DataTable)rcc);
            buscarCuentas.LocalReport.DataSources.Clear();
            buscarCuentas.LocalReport.DataSources.Add(rds);

            this.buscarCuentas.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RelacionClienteCuentaTableAdapter adapter = new RelacionClienteCuentaTableAdapter();
            RelacionClienteCuentaDataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSRCC", (DataTable)rcc);
            buscarCuentas.LocalReport.DataSources.Clear();
            buscarCuentas.LocalReport.DataSources.Add(rds);

            this.buscarCuentas.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            RelacionClienteCuentaTableAdapter adapter = new RelacionClienteCuentaTableAdapter();
            RelacionClienteCuentaDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSRCC", (DataTable)rcc);
            buscarCuentas.LocalReport.DataSources.Clear();
            buscarCuentas.LocalReport.DataSources.Add(rds);

            this.buscarCuentas.RefreshReport();
        }
    }
}
