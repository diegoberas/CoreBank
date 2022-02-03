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
    public partial class frmEditarUsuario : Form
    {
        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            this.editarUsuario.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            editarUsuario.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Usuario.rdlc";
            RelacionClienteUsuarioTableAdapter adapter = new RelacionClienteUsuarioTableAdapter();
            RelacionClienteUsuarioDataTable rcc = adapter.GetDataByCedula2(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            editarUsuario.LocalReport.DataSources.Clear();
            editarUsuario.LocalReport.DataSources.Add(rds);
            this.editarUsuario.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
                                      
            if (txtID.Text == "" || string.IsNullOrEmpty(txtCC.Text))
            {
                MessageBox.Show("Necesitas el ID del usuario y la cedula del cliente para poder editarlo.");
            }
            else
            {
                
                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContra.Text) || string.IsNullOrEmpty(txtTipo.Text))
                {
                    MessageBox.Show("No se pudo actualizar. Se encontraron campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (txtTipo.Text == "administrador" || txtTipo.Text == "cliente")
                        {
                            int id = int.Parse(txtID.Text);
                            tblUsuariosDataTable udt = adapter.GetDataByID(id);
                            if (udt.Count == 1)
                            {


                                adapter.ppUpdateUsuario(id, txtUsuario.Text, txtContra.Text, txtTipo.Text, txtCC.Text);
                                MessageBox.Show("Se han guardado los cambios.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtID.Clear();
                                txtContra.Clear();
                                txtUsuario.Clear();
                                txtTipo.Clear();
                                txtCC.Clear();


                            }
                            else
                            {
                                MessageBox.Show("Usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtID.Clear();
                                txtContra.Clear();
                                txtUsuario.Clear();
                                txtTipo.Clear();
                                txtCC.Clear();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Error de formato en el campo TIPO. Por favor llenar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTipo.Clear();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error de formato en el campo ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                        
                    }
                    


                }
            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCC.Clear();
            txtID.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtTipo.Clear();
            
        }
    }
}
