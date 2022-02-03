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
    public partial class frmBuscarPrestamo : Form
    {
        public frmBuscarPrestamo()
        {
            InitializeComponent();
        }

        private void frmBuscarPrestamo_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            buscarPrestamo.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BuscarPrestamo.rdlc";
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            buscarPrestamo.LocalReport.DataSources.Clear();
            buscarPrestamo.LocalReport.DataSources.Add(rds);

            this.buscarPrestamo.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            buscarPrestamo.LocalReport.DataSources.Clear();
            buscarPrestamo.LocalReport.DataSources.Add(rds);

            this.buscarPrestamo.RefreshReport();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            buscarPrestamo.LocalReport.DataSources.Clear();
            buscarPrestamo.LocalReport.DataSources.Add(rds);

            this.buscarPrestamo.RefreshReport();
        }
    }
}
