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
    public partial class frmEditarPrestamo : Form
    {
        public frmEditarPrestamo()
        {
            InitializeComponent();
        }

        private void frmEditarPrestamo_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            
            this.editarPrestamo.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
           


            if (txtID.Text == "")
            {
                MessageBox.Show("Necesitas el ID del PRESTAMO para poder editarlo.");
            }
            else
            {
                if (string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("No se pudo actualizar. Por favor llenar todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        int id = int.Parse(txtID.Text);
                        tblPrestamos1DataTable rcc = adapter.GetDataByID(id);
                        if (rcc.Count == 1)
                        {
                            decimal cantidad = decimal.Parse(txtCantidad.Text);

                            adapter.UpdatePrestamo(txtTelefono.Text, txtEmail.Text, cantidad, id, id);
                            MessageBox.Show("Prestamo actualizado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTelefono.Clear();
                            txtEmail.Clear();
                            txtCantidad.Clear();
                            txtID.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Prestamo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTelefono.Clear();
                            txtEmail.Clear();
                            txtCantidad.Clear();
                            txtID.Clear();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTelefono.Clear();
                        txtEmail.Clear();
                        txtCantidad.Clear();
                        txtID.Clear();
                    }
                    
                       

                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCantidad.Clear();
            txtID.Clear();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            editarPrestamo.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BuscarPrestamo.rdlc";
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetDataByCedula(txtCedula.Text);
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            editarPrestamo.LocalReport.DataSources.Clear();
            editarPrestamo.LocalReport.DataSources.Add(rds);
            this.editarPrestamo.RefreshReport();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
