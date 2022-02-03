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
    public partial class frmBorrarPerfil : Form
    {
        public frmBorrarPerfil()
        {
            InitializeComponent();
        }

        private void frmBorrarPerfil_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            borrarPerfil.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\BPerfil.rdlc";
            RelacionClientePerfilTableAdapter adapter = new RelacionClientePerfilTableAdapter();
            RelacionClientePerfilDataTable rcc = adapter.GetData();
            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
            borrarPerfil.LocalReport.DataSources.Clear();
            borrarPerfil.LocalReport.DataSources.Add(rds);

            
            this.borrarPerfil.RefreshReport();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tblPerfilesTableAdapter adapter = new tblPerfilesTableAdapter();
           

            if (txtID.Text == "")
            {
                MessageBox.Show("Debes introducir el ID del perfil que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    tblPerfilesDataTable pdt = adapter.GetDataByID(id);
                    if (pdt.Count == 1)
                    {
                        var result = MessageBox.Show("Deseas eliminar este perfil?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {

                            //Borra perfil
                            adapter.DeletePerfil(id);
                            txtID.Clear();

                            RelacionClientePerfilTableAdapter relacion = new RelacionClientePerfilTableAdapter();
                            RelacionClientePerfilDataTable rcc = relacion.GetData();
                            ReportDataSource rds = new ReportDataSource("DSPerfil", (DataTable)rcc);
                            borrarPerfil.LocalReport.DataSources.Clear();
                            borrarPerfil.LocalReport.DataSources.Add(rds);


                            this.borrarPerfil.RefreshReport();
                            MessageBox.Show("Perfil borrado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Perfil no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtID.Clear();
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();

                }
                

            }




        }
        private void borrarPerfil_Load(object sender, EventArgs e)
        {

        }

        
    }
}
