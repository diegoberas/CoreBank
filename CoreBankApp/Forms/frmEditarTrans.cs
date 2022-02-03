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
    public partial class frmEditarTrans : Form
    {
        public frmEditarTrans()
        {
            InitializeComponent();
        }

        private void frmEditarTrans_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            this.editarTrans.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();

            if (txtID.Text == "")
            {
                MessageBox.Show("Necesitas el ID de la transaccion para poder editarlo.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombreP.Text) || string.IsNullOrEmpty(txtTipo.Text))
                {
                    MessageBox.Show("No se pudo actualizar. Por favor llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtTipo.Text == "C" || txtTipo.Text == "D")
                    {
                        try
                        {
                            
                            int id = int.Parse(txtID.Text);
                            adapter.UpdateTransaccion(txtTipo.Text, txtNombreP.Text, DateTime.Now, id, id);
                            txtID.Clear();
                            txtNombreP.Clear();
                            txtTipo.Clear();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtID.Clear();
                            txtNombreP.Clear();
                            txtTipo.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error de formato en el campo TIPO. Por favor llenar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTipo.Clear();
                    }


                }
            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombreP.Clear();
            txtTipo.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            editarTrans.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Transaccion.rdlc";
            tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
            tblTransaccionDataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
             ReportDataSource rds = new ReportDataSource("DSTrans", (DataTable)rcc);
            editarTrans.LocalReport.DataSources.Clear();
            editarTrans.LocalReport.DataSources.Add(rds);
            this.editarTrans.RefreshReport();
        }
    }
}
