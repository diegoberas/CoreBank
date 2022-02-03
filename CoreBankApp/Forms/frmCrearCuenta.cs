using CoreBankApp.DSCoreTableAdapters;
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
    public partial class frmCrearCuenta : Form
    {
        public frmCrearCuenta()
        {
            InitializeComponent();
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            MessageBox.Show("Para crear una cuenta, la cedula de un cliente debe existir en la base de datos.", "Dato Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();
            tblClientesTableAdapter adaptercliente = new tblClientesTableAdapter();

            //Validacion espacios vacios
            if (string.IsNullOrEmpty(txtPropietario.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtMoneda.Text) || string.IsNullOrEmpty(txtEstado.Text))
            {
                MessageBox.Show("No se pudo crear. Se encontraron campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                try
                {
                    if (txtTipo.Text == "C" || txtTipo.Text == "D")
                    {

                        if (txtEstado.Text == "A" || txtEstado.Text == "I")
                        {

                            if (txtMoneda.Text == "DOP" || txtMoneda.Text == "USD" || txtMoneda.Text == "EURO" || txtMoneda.Text == "JPY")
                            {
                                //Validar cliente
                                tblClientesDataTable clien = adaptercliente.GetDataByCedula(txtCedula.Text);
                                if (clien.Count == 1)
                                {
                                    //Validar cuenta
                                    tblCuentasDataTable cdt = adapter.GetDataByPropietarioCedula(txtPropietario.Text, txtCedula.Text);
                                    if (cdt.Count == 1)
                                    {
                                        MessageBox.Show("Cuenta ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtPropietario.Clear();
                                        txtCedula.Clear();
                                        txtEstado.Clear();
                                        txtMoneda.Clear();
                                        txtTipo.Clear();
                                    }
                                    else
                                    {
                                        //Crea Cuenta
                                        adapter.ppInsertCuenta(txtPropietario.Text, txtCedula.Text, txtTipo.Text, txtMoneda.Text, txtEstado.Text);
                                        MessageBox.Show("Cuenta creada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        txtPropietario.Clear();
                                        txtCedula.Clear();
                                        txtEstado.Clear();
                                        txtMoneda.Clear();
                                        txtTipo.Clear();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtPropietario.Clear();
                                    txtCedula.Clear();
                                    txtEstado.Clear();
                                    txtMoneda.Clear();
                                    txtTipo.Clear();
                                }




                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos. Por favor llenar correctamente el campo MONEDA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtMoneda.Clear();
                                txtMoneda.Refresh();
                            }




                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos. Por favor llenar correctamente el campo ESTADO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtEstado.Clear();
                            txtEstado.Refresh();
                        }


                    }

                    else
                    {
                        MessageBox.Show("Datos incorrectos. Por favor llenar correctamente el campo TIPO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTipo.Clear();
                        txtTipo.Refresh();

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPropietario.Clear();
                    txtCedula.Clear();
                    txtEstado.Clear();
                    txtMoneda.Clear();
                    txtTipo.Clear();

                }
                
                
            }
               
           

            

            




        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPropietario.Clear();
            txtCedula.Clear();
            txtEstado.Clear();
            txtMoneda.Clear();
            txtTipo.Clear();
        }
    }
}
