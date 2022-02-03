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
    public partial class frmBorrarTrans : Form
    {
        public frmBorrarTrans()
        {
            InitializeComponent();
        }

        private void frmBorrarTrans_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            borrarTrans.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Transaccion.rdlc";
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            tblTransaccionDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
            borrarTrans.LocalReport.DataSources.Clear();
            borrarTrans.LocalReport.DataSources.Add(rds);
            this.borrarTrans.RefreshReport();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes introducir el ID de la transaccion que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    tblTransaccionDataTable tdt = adapter.GetDataByID(id);
                    if (tdt.Count == 1)
                    {
                        var result = MessageBox.Show("Deseas eliminar esta transaccion?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            //Borra perfil
                            adapter.DeleteTransaccion(id);
                            txtID.Clear();

                            tblTransaccionDataTable rcc = adapter.GetData();
                            ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
                            borrarTrans.LocalReport.DataSources.Clear();
                            borrarTrans.LocalReport.DataSources.Add(rds);
                            this.borrarTrans.RefreshReport();
                            MessageBox.Show("Transaccion eliminada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transaccion no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error de formato. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();
            }
            

        }
    }
}
