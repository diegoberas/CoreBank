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
    public partial class frmCrearPrestamo : Form
    {
        public frmCrearPrestamo()
        {
            InitializeComponent();
        }

        private void frmCrearPrestamo_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            MessageBox.Show("Para crear un prestamo el cliente debe existir en la base de datos.", "Dato Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblClientesTableAdapter adaptercliente = new tblClientesTableAdapter();

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No se pudo crear. Se encontraron campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    
                    tblClientesDataTable clien = adaptercliente.GetDataByCedula(txtCedula.Text);
                    decimal cantidad = decimal.Parse(txtCantidad.Text);
                    decimal falta = 0;

                    if (clien.Count == 1)
                    {
                        adapter.ppInsertPrestamo(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtTelefono.Text, txtEmail.Text, cantidad, falta);
                        MessageBox.Show("Prestamo creado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCedula.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        txtCantidad.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtCedula.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        txtCantidad.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCedula.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    txtCantidad.Clear();

                }
                

               

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCantidad.Clear();
        }
    }
}
