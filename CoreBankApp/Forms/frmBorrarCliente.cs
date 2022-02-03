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
    public partial class BorrarCliente : Form
    {
        public BorrarCliente()
        {
            InitializeComponent();

        }

        private void frmBorrarCliente_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana

            //Muestra la data 
            DeleteCliente.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BorrarCliente.rdlc";
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable dt = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSBorrar", (DataTable)dt);
            DeleteCliente.LocalReport.DataSources.Add(rds);
           
            this.DeleteCliente.RefreshReport();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tblClientesTableAdapter adapter = new tblClientesTableAdapter();
            tblClientesDataTable data = adapter.GetDataByCU(txtCedula.Text, txtUsuario.Text);
            tblCuentasTableAdapter adapterCuenta = new tblCuentasTableAdapter();
            tblPrestamos1TableAdapter adapterPrestamo = new tblPrestamos1TableAdapter();
            tblTransaccionTableAdapter adapterTrans = new tblTransaccionTableAdapter();
            tblPerfilesTableAdapter adapterPerfil = new tblPerfilesTableAdapter();
            

                //Validar campo vacio
            if (string.IsNullOrEmpty(txtCedula.Text) && string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debes introducir la cedula y usuario del cliente que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //Validar que existe
                if (data.Count == 1)
                {
                    var result = MessageBox.Show("Se borrarán todos los datos relacionados al cliente. Estas seguro que quieres eliminarlo? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //Borra toda la data del cliente
                        adapter.ppDeleteClienteUsuario(txtCedula.Text, txtUsuario.Text);
                        adapterCuenta.DeleteByCedula(txtCedula.Text);
                        adapterPrestamo.DeleteByCedula(txtCedula.Text);
                        adapterTrans.DeleteByCedula(txtCedula.Text);
                        adapterPerfil.DeleteByCedula(txtCedula.Text);
                        txtCedula.Clear();
                        txtUsuario.Clear();

                        tblClientesDataTable dt = adapter.GetData();
                        ReportDataSource rds = new ReportDataSource("DSBorrar", (DataTable)dt);
                        DeleteCliente.LocalReport.DataSources.Clear();
                        DeleteCliente.LocalReport.DataSources.Add(rds);
                        this.DeleteCliente.RefreshReport();
                        MessageBox.Show("Cliente eliminado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    
                }
                else
                {
                    MessageBox.Show("El Cliente con esa cedula y usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCedula.Clear();
                    txtUsuario.Clear();
                }

                


            }

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
