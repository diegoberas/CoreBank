using CoreBankApp.DSCoreTableAdapters;
using Microsoft.Reporting.WinForms;
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
    public partial class frmEditarCliente : Form
    {
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            this.Ecliente.RefreshReport();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtCedula.Text))  //Busca por nombre y apellido
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text))
                {
                    MessageBox.Show("Necesitas Nombre y Apellido y/o Cedula para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Ecliente.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Ecliente.rdlc";
                    tblClientesTableAdapter adapter = new tblClientesTableAdapter();
                    tblClientesDataTable dt = adapter.GetDataByNombreCompleto(txtNombre.Text, txtApellido.Text);
                    ReportDataSource rds = new ReportDataSource("DSEditar", (DataTable)dt);
                    Ecliente.LocalReport.DataSources.Clear();
                    Ecliente.LocalReport.DataSources.Add(rds);
                    this.Ecliente.RefreshReport();
                }
                
            }
            else if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text)) //Busca por cedula
            {
                Ecliente.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Ecliente.rdlc";
                tblClientesTableAdapter adapter = new tblClientesTableAdapter();
                tblClientesDataTable dt = adapter.GetDataByCedula(txtCedula.Text);
                ReportDataSource rds = new ReportDataSource("DSEditar", (DataTable)dt);
                Ecliente.LocalReport.DataSources.Clear();
                Ecliente.LocalReport.DataSources.Add(rds);
                this.Ecliente.RefreshReport();
            }
            else  //Busca por Nombre completo y Cedula 
            {
                
                 Ecliente.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Ecliente.rdlc";
                 tblClientesTableAdapter adapter = new tblClientesTableAdapter();
                 tblClientesDataTable dt = adapter.GetDataByTodo(txtNombre.Text, txtApellido.Text, txtCedula.Text);
                 ReportDataSource rds = new ReportDataSource("DSEditar", (DataTable)dt);
                 Ecliente.LocalReport.DataSources.Clear();
                 Ecliente.LocalReport.DataSources.Add(rds);
                 this.Ecliente.RefreshReport();
                
            }
            


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable clien = adapter.GetData();
            

            //Validacion de campos vacios
            if (string.IsNullOrEmpty(txtNNombre.Text) || string.IsNullOrEmpty(txtNApellido.Text) || string.IsNullOrEmpty(txtNCedula.Text) || string.IsNullOrEmpty(txtNCorreo.Text) || string.IsNullOrEmpty(txtNTelefono.Text))
            {
                MessageBox.Show("No se pudo actualizar. Por favor llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            else
            {
                //Validacion de ID
                if (txtId.Text == "")
                {
                    MessageBox.Show("Necesitas el ID del cliente para poder editarlo.");
                }
                else
                {
                   


                    //Actualizar cliente
                    int id = int.Parse(txtId.Text);
                    adapter.UpdateCliente2(txtNNombre.Text, txtNApellido.Text, txtNCedula.Text, txtNCorreo.Text, txtNTelefono.Text, id, id);
                    MessageBox.Show("Se han guardado los cambios.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNNombre.Clear();
                    txtNApellido.Clear();
                    txtNCedula.Clear();
                    txtNCorreo.Clear();
                    txtNTelefono.Clear();
                    txtId.Clear();


                    

                }
                
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNNombre.Clear();
            txtNApellido.Clear();
            txtNCedula.Clear();
            txtNCorreo.Clear();
            txtNTelefono.Clear();
            txtId.Clear();
        }
    }
}
