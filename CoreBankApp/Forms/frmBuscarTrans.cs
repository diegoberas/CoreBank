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
    public partial class frmBuscarTrans : Form
    {
        public frmBuscarTrans()
        {
            InitializeComponent();
        }

        private void frmBuscarTrans_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            buscarTrans.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Transaccion.rdlc";
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            tblTransaccionDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
            buscarTrans.LocalReport.DataSources.Clear();
            buscarTrans.LocalReport.DataSources.Add(rds);

            this.buscarTrans.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            tblTransaccionDataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
            buscarTrans.LocalReport.DataSources.Clear();
            buscarTrans.LocalReport.DataSources.Add(rds);

            this.buscarTrans.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            tblTransaccionDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
            buscarTrans.LocalReport.DataSources.Clear();
            buscarTrans.LocalReport.DataSources.Add(rds);

            this.buscarTrans.RefreshReport();
        }

        private void btnpdf_Click(object sender, EventArgs e)
        {
        }   



        
    }
}
