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
    public partial class frmEditarCuenta : Form
    {
        public frmEditarCuenta()
        {
            InitializeComponent();
        }

        private void frmEditarCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            this.editarCuenta.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            editarCuenta.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\ECuenta.rdlc";
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();
            tblCuentasDataTable dt = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource report = new ReportDataSource("DSEcuenta", (DataTable) dt);
            editarCuenta.LocalReport.DataSources.Clear();
            editarCuenta.LocalReport.DataSources.Add(report);
            this.editarCuenta.RefreshReport();
           
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();

            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Necesitas el ID de la cuenta para poder editarlo.");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtNPropietario.Text) || string.IsNullOrEmpty(txtNTipo.Text) || string.IsNullOrEmpty(txtNMoneda.Text) || string.IsNullOrEmpty(txtNBalance.Text) || string.IsNullOrEmpty(txtNEstado.Text))
                    {
                        MessageBox.Show("No se pudo actualizar. Se encontraron campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (txtNTipo.Text == "C" || txtNTipo.Text == "D")
                        {
                            if (txtNMoneda.Text == "DOP" || txtNMoneda.Text == "USD" || txtNMoneda.Text == "EURO" || txtNMoneda.Text == "JPY")
                            {
                                if (txtNEstado.Text == "A" || txtNEstado.Text == "I")
                                {

                                    int id = int.Parse(txtID.Text);
                                    tblCuentasDataTable dt = adapter.GetDataByID(id);
                                    if (dt.Count == 1)
                                    {
                                        decimal Nbalance = decimal.Parse(txtNBalance.Text);
                                        adapter.UpdateCuenta2(txtNPropietario.Text, txtNTipo.Text, txtNMoneda.Text, Nbalance, txtNEstado.Text, id, id);
                                        MessageBox.Show("Cuenta actualizada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtNPropietario.Clear();
                                        txtNTipo.Clear();
                                        txtNMoneda.Clear();
                                        txtNBalance.Clear();
                                        txtNEstado.Clear();
                                        txtID.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cuenta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtNPropietario.Clear();
                                        txtNTipo.Clear();
                                        txtNMoneda.Clear();
                                        txtNBalance.Clear();
                                        txtNEstado.Clear();
                                        txtID.Clear();
                                    }




                                }
                                else
                                {

                                    MessageBox.Show("Formato incorrecto. Por favor llenar campo ESTADO correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtNEstado.Clear();
                                }
                            }
                            else
                            {

                                MessageBox.Show("Formato incorrecto. Por favor llenar campo MONEDA correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtNMoneda.Clear();
                            }
                        }
                        else
                        {

                            MessageBox.Show("Formato incorrecto. Por favor llenar campo TIPO correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNTipo.Clear();
                        }

                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNPropietario.Clear();
                txtNTipo.Clear();
                txtNMoneda.Clear();
                txtNBalance.Clear();
                txtNEstado.Clear();
                txtID.Clear();

            }
            


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNPropietario.Clear();
            txtNTipo.Clear();
            txtNMoneda.Clear();
            txtNBalance.Clear();
            txtNEstado.Clear();
             txtID.Clear();
        }

        private void txtNPropietario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
