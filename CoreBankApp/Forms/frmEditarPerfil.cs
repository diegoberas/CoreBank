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
    public partial class frmEditarPerfil : Form
    {
        public frmEditarPerfil()
        {
            InitializeComponent();
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            this.editarPerfil.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblPerfilesTableAdapter adapter = new tblPerfilesTableAdapter();

            if (txtID.Text == "")
            {
                MessageBox.Show("Necesitas el ID del PERFIL para poder editarlo.");
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtFecha.Text) || string.IsNullOrEmpty(txtNacionalidad.Text) || string.IsNullOrEmpty(txtSexo.Text) || string.IsNullOrEmpty(txtOcupacion.Text))
                    {
                        MessageBox.Show("No se pudo actualizar. Por favor llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (txtSexo.Text == "M" || txtSexo.Text == "F")
                        {

                            int edad = int.Parse(txtEdad.Text);
                            int id = int.Parse(txtID.Text);
                            tblPerfilesDataTable pdt = adapter.GetDataByID(id);

                            if (pdt.Count == 1)
                            {
                                adapter.UpdatePerfil(edad, txtFecha.Text, txtNacionalidad.Text, txtSexo.Text, txtOcupacion.Text, id, id);
                                MessageBox.Show("Perfil actualizado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtID.Clear();
                                txtEdad.Clear();
                                txtFecha.Clear();
                                txtNacionalidad.Clear();
                                txtOcupacion.Clear();
                                txtSexo.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Perfil no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtID.Clear();
                                txtEdad.Clear();
                                txtFecha.Clear();
                                txtNacionalidad.Clear();
                                txtOcupacion.Clear();
                                txtSexo.Clear();
                            }




                        }
                        else
                        {
                            MessageBox.Show("Error de formato en el campo SEXO. Por favor llenar correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSexo.Clear();
                        }


                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                    txtEdad.Clear();

                }
                
            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtEdad.Clear();
            txtFecha.Clear();
            txtNacionalidad.Clear();
            txtOcupacion.Clear();
            txtSexo.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            editarPerfil.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BPerfil.rdlc";
            RelacionClientePerfilTableAdapter adapter = new RelacionClientePerfilTableAdapter();
            RelacionClientePerfilDataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
            editarPerfil.LocalReport.DataSources.Clear();
            editarPerfil.LocalReport.DataSources.Add(rds);

            this.editarPerfil.RefreshReport();
        }
    }
}
