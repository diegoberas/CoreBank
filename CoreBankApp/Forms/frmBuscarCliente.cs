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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {

            InitializeComponent();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            //Lista clientes
            Bcliente.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Bcliente.rdlc";

            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable dt = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSCliente", (DataTable) dt);
            Bcliente.LocalReport.DataSources.Add(rds);

            this.Bcliente.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar por Cedula
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable dt = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSCliente", (DataTable)dt);
            Bcliente.LocalReport.DataSources.Clear();
            Bcliente.LocalReport.DataSources.Add(rds);

            this.Bcliente.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //Busca todos los clientes
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable dt = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSCliente", (DataTable)dt);
            Bcliente.LocalReport.DataSources.Clear();
            Bcliente.LocalReport.DataSources.Add(rds);

            this.Bcliente.RefreshReport();
        }
    }
}
