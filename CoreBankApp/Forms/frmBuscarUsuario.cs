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
    public partial class frmBuscarUsuario : Form
    {
        public frmBuscarUsuario()
        {
            InitializeComponent();
        }

        //Buscar Usuarios de clientes
        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            buscarUsuario.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Usuario.rdlc";
            RelacionClienteUsuarioTableAdapter adapter = new RelacionClienteUsuarioTableAdapter();
            RelacionClienteUsuarioDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            buscarUsuario.LocalReport.DataSources.Clear();
            buscarUsuario.LocalReport.DataSources.Add(rds);
            this.buscarUsuario.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RelacionClienteUsuarioTableAdapter adapter = new RelacionClienteUsuarioTableAdapter();
            RelacionClienteUsuarioDataTable rcc = adapter.GetDataByCedula2(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            buscarUsuario.LocalReport.DataSources.Clear();
            buscarUsuario.LocalReport.DataSources.Add(rds);
            this.buscarUsuario.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            RelacionClienteUsuarioTableAdapter adapter = new RelacionClienteUsuarioTableAdapter();
            RelacionClienteUsuarioDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            buscarUsuario.LocalReport.DataSources.Clear();
            buscarUsuario.LocalReport.DataSources.Add(rds);
            this.buscarUsuario.RefreshReport();
        }

        private void btnAdmi_Click(object sender, EventArgs e)
        {
            //Buscar administradores
            string admi = "administrador";
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            tblUsuariosDataTable rcc = adapter.GetDataByAdmi(admi);
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            buscarUsuario.LocalReport.DataSources.Clear();
            buscarUsuario.LocalReport.DataSources.Add(rds);
            this.buscarUsuario.RefreshReport();
        }
    }
}
