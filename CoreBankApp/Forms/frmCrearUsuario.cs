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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            tblUsuariosDataTable udt = adapter.GetDataByUsuario(txtUsuario.Text);
            tblClientesTableAdapter clien = new tblClientesTableAdapter();
            tblClientesDataTable cdt = clien.GetDataByUsuario(txtUsuario.Text);

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContra.Text) || string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("No se pudo crear. Se encontraron campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (udt.Count == 1)
                {
                    
                    MessageBox.Show("Usuario ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContra.Clear();
                    txtTipo.Clear();
                }
                else
                {
                    if (txtTipo.Text == "cliente")
                    {
                        if (cdt.Count == 1)
                        {
                            adapter.ppInsertUsuario(txtUsuario.Text, txtContra.Text, txtTipo.Text);
                            MessageBox.Show("Usuario agregado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUsuario.Clear();
                            txtContra.Clear();
                            txtTipo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró cliente con ese usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Clear();
                            txtContra.Clear();
                            txtTipo.Clear();
                        }
                        

                    }
                    
                    else if (txtTipo.Text == "administrador")
                    {
                        adapter.ppInsertUserAdmi(txtUsuario.Text, txtContra.Text, txtTipo.Text);
                        MessageBox.Show("Administrador agregado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Clear();
                        txtContra.Clear();
                        txtTipo.Clear();
                    }
                    else
                    {
                        txtTipo.Clear();
                        MessageBox.Show("Formato incorrecto en el campo TIPO DE USUARIO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }
                


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContra.Clear();
            txtTipo.Clear();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            MessageBox.Show("Para crear un usuario tipo cliente, primero debe tener el cliente registrado en la base de datos.", "Dato Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
