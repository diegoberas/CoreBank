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
    public partial class frmBorrarPrestamo : Form
    {
        public frmBorrarPrestamo()
        {
            InitializeComponent();
        }

        private void frmBorrarPrestamo_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            borrarPrestamo.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BuscarPrestamo.rdlc";
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();
            tblPrestamos1DataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSBprestamo", (DataTable)rcc);
            borrarPrestamo.LocalReport.DataSources.Clear();
            borrarPrestamo.LocalReport.DataSources.Add(rds);
            this.borrarPrestamo.RefreshReport();
        }

        private void borrarPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tblPrestamos1TableAdapter adapter = new tblPrestamos1TableAdapter();

            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes introducir el ID del prestamo que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    tblPrestamos1DataTable pdt = adapter.GetDataByID(id);
                    if (pdt.Count == 1)
                    {
                        var result = MessageBox.Show("Deseas eliminar este prestamo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            adapter.DeletePrestamo(id);
                            
                            tblPrestamos1DataTable rcc = adapter.GetData();
                            ReportDataSource rps = new ReportDataSource("DSBprestamo", (DataTable)rcc);
                            borrarPrestamo.LocalReport.DataSources.Clear();
                            borrarPrestamo.LocalReport.DataSources.Add(rps);

                            this.borrarPrestamo.RefreshReport();
                            MessageBox.Show("Prestamo borrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtID.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Prestamo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                    }



                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Clear();

            }
            


        }
    }
}
