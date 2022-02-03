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
    public partial class frmBorrarCuenta : Form
    {
        public frmBorrarCuenta()
        {
            InitializeComponent();
        }

        private void frmBorrarCuenta_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;  //Maximizar Ventana
            borrarCuenta.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BorrarCuenta.rdlc";
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();
            tblCuentasDataTable dt = adapter.GetData();
            ReportDataSource rps = new ReportDataSource("DSBorrarCuenta", (DataTable) dt);
            borrarCuenta.LocalReport.DataSources.Add(rps);

            
            this.borrarCuenta.RefreshReport();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            tblCuentasTableAdapter adapter = new tblCuentasTableAdapter();

            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Debes introducir el ID de la cuenta que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    tblCuentasDataTable cdt = adapter.GetDataByID(id);
                    if (cdt.Count == 1)
                    {
                        var result = MessageBox.Show("Deseas eliminar esta cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            adapter.DeleteCuenta(id);
                            txtID.Clear();

                            tblCuentasDataTable dt = adapter.GetData();
                            ReportDataSource rps = new ReportDataSource("DSBorrarCuenta", (DataTable)dt);
                            borrarCuenta.LocalReport.DataSources.Clear();
                            borrarCuenta.LocalReport.DataSources.Add(rps);

                            this.borrarCuenta.RefreshReport();
                            MessageBox.Show("Cuenta eliminada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cuenta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
