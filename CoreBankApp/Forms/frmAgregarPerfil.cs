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
    public partial class frmAgregarPerfil : Form
    {
        public frmAgregarPerfil()
        {
            InitializeComponent();
        }

        private void frmAgregarPerfil_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            MessageBox.Show("Para crear un perfil, debe tener el cliente registrado en la base de datos.", "Dato Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tblPerfilesTableAdapter adapter = new tblPerfilesTableAdapter();           
            tblClientesTableAdapter adaptercliente = new tblClientesTableAdapter();
            


            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtNacionalidad.Text) || string.IsNullOrEmpty(txtSexo.Text) || string.IsNullOrEmpty(txtOcupacion.Text))
            {
                MessageBox.Show("No se pudo crear. Se encontraron campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                try
                {
                    if (txtSexo.Text == "M" || txtSexo.Text == "F")
                    {
                        tblClientesDataTable clien = adaptercliente.GetDataByCedula(txtCedula.Text);
                        int edad = int.Parse(txtEdad.Text);

                        if (clien.Count == 1)
                        {
                            adapter.ppInsertPerfil(txtNombre.Text, txtApellido.Text, txtCedula.Text, edad, txtFecha.Text, txtNacionalidad.Text, txtSexo.Text, txtOcupacion.Text);
                            MessageBox.Show("Perfil agregado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtCedula.Clear();
                            txtEdad.Clear();
                            txtFecha.Clear();
                            txtNacionalidad.Clear();
                            txtSexo.Clear();
                            txtOcupacion.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Cliente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtCedula.Clear();

                        }



                    }
                    else
                    {

                        MessageBox.Show("Formato incorrecto en el campo SEXO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSexo.Clear();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error de formato en el campo EDAD.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtEdad.Clear();
                   
                    


                }
                


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
            txtFecha.Clear();
            txtNacionalidad.Clear();
            txtSexo.Clear();
            txtOcupacion.Clear();
        }

       
    }
}
