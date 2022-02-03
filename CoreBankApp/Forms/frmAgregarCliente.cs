using CoreBankApp.DSCoreTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CoreBankApp.DSCore;

namespace CoreBankApp.Forms
{
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //No Borrar
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable clien = adapter.GetDataByCedula(txtCedula.Text);

              //Validacion espacios vacios
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("No se pudo agregar. Se encontraron campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (clien.Count == 1)
                {
                    MessageBox.Show("Cliente existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCedula.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                    txtUsuario.Clear();
                }
                else
                {
                    //Agrega cliente a la DB
                    adapter.ppInsertCliente(txtNombre.Text, txtApellido.Text, txtCedula.Text, txtCorreo.Text, txtTelefono.Text, txtUsuario.Text);
                    MessageBox.Show("Cliente agregado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCedula.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                    txtUsuario.Clear();
                }

                
                
            }


            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtUsuario.Clear();
        }
    }
}
