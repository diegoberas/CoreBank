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
    public partial class frmCrearTrans : Form
    {
        public frmCrearTrans()
        {
            InitializeComponent();
        }

        private void frmCrearTrans_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            MessageBox.Show("Para hacer una transacción, debe tener balance suficiente en su cuenta de banco y los datos requeridos deben estar correctos.", "Dato Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtTipo.Clear();
            txtNombrep.Clear();
            txtPreciop.Clear();
            txtIdCuentaE.Clear();
           txtIdCuentaR.Clear();
            
        }

        private void btnRealizar_Click(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtTipo.Text) || string.IsNullOrEmpty(txtNombrep.Text) || txtPreciop.Text == "" || txtIdCuentaE.Text == "" ||  txtIdCuentaR.Text == "" || txtBalanceE.Text == "" || txtBalanceR.Text == "")
            {
                MessageBox.Show("No se realizar transacción. Se encontraron campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                tblTransaccionTableAdapter adapter = new tblTransaccionTableAdapter();
                tblCuentasTableAdapter cuenta = new tblCuentasTableAdapter();
               
                try
                {
                    tblCuentasDataTable cdt = cuenta.GetDataByID(int.Parse(txtIdCuentaE.Text));
                    if (cdt.Count == 1 )
                    {
                        if (txtTipo.Text == "C" || txtTipo.Text == "D")
                        {

                            int idEmisor = int.Parse(txtIdCuentaE.Text);
                            int idReceptor = int.Parse(txtIdCuentaR.Text);
                            decimal precio = decimal.Parse(txtPreciop.Text);
                            decimal balanceE = decimal.Parse(txtBalanceE.Text);
                            decimal balanceR = decimal.Parse(txtBalanceR.Text);
                            
                            
                                adapter.ppInsertTrans(txtCedula.Text, txtTipo.Text, txtNombrep.Text, precio, idEmisor, idReceptor,balanceE , balanceR);
                                MessageBox.Show("Se ha realizado la transacción.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCedula.Clear();
                                txtTipo.Clear();
                                txtNombrep.Clear();
                                txtPreciop.Clear();
                                txtIdCuentaE.Clear();
                                txtIdCuentaR.Clear();
                            txtBalanceE.Clear();
                            txtBalanceR.Clear();

                                                     
                        }
                        else
                        {
                            
                            MessageBox.Show("Formato incorrecto en el campo TIPO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtTipo.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Cuenta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCedula.Clear();
                        txtTipo.Clear();
                        txtNombrep.Clear();
                        txtPreciop.Clear();
                        txtIdCuentaE.Clear();
                        txtIdCuentaR.Clear();
                        txtBalanceE.Clear();
                        txtBalanceR.Clear();


                    }



                }
                catch (Exception)
                {

                    MessageBox.Show("Error. Intente de nuevo", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedula.Clear();
                    txtTipo.Clear();
                    txtNombrep.Clear();
                    txtPreciop.Clear();
                    txtIdCuentaE.Clear();
                    txtIdCuentaR.Clear();
                    txtBalanceE.Clear();
                    txtBalanceR.Clear();

                }
                


            }


        }
    }
}
