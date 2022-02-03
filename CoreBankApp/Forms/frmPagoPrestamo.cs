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
    public partial class frmPagoPrestamo : Form
    {
        public frmPagoPrestamo()
        {
            InitializeComponent();
        }

        private void frmPagoPrestamo_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            this.pagoPrestamo.RefreshReport();
        }





        private void pagoPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pagoPrestamo.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BuscarPrestamo.rdlc";
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetDataByCedula(txtCedulaBuscar.Text);
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            pagoPrestamo.LocalReport.DataSources.Clear();
            pagoPrestamo.LocalReport.DataSources.Add(rds);
            this.pagoPrestamo.RefreshReport();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            tblPagoPrestamoTableAdapter adapter = new tblPagoPrestamoTableAdapter();
            tblPrestamos1TableAdapter prestamo = new tblPrestamos1TableAdapter();

            if (string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtIdPrestamo.Text) || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("No se pudo pagar. Se encontraron campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    tblPrestamos1DataTable rcc = prestamo.GetDataByCedula(txtCedula.Text);

                    if (rcc.Count == 1)
                    {
                        int id = int.Parse(txtIdPrestamo.Text);
                        decimal cantidad = decimal.Parse(txtCantidad.Text);
                        adapter.ppPagarPrestamo(id, txtCedula.Text, cantidad);
                        MessageBox.Show("Pago registrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidad.Clear();
                        txtCedula.Clear();
                        txtIdPrestamo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Prestamo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCantidad.Clear();
                        txtCedula.Clear();
                        txtIdPrestamo.Clear();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCantidad.Clear();
                    txtIdPrestamo.Clear();

                }
                

            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtCedula.Clear();
            txtIdPrestamo.Clear();
        }
    }
}
