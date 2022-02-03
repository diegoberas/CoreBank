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
    public partial class frmBorrarADMI : Form
    {
        public frmBorrarADMI()
        {
            InitializeComponent();
        }

        private void frmBorrarADMI_Load(object sender, EventArgs e)
        {
            string admi = "administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            borrarAdmi.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Usuario.rdlc";
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            tblUsuariosDataTable rcc = adapter.GetDataByAdmi(admi);
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            borrarAdmi.LocalReport.DataSources.Clear();
            borrarAdmi.LocalReport.DataSources.Add(rds);
     
            this.borrarAdmi.RefreshReport();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string admi = "administrador";
           
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            
            //Validar campo vacio
            if (txtID.Text == "")
            {
                MessageBox.Show("Debes introducir el ID del administrador que deseas eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    tblUsuariosDataTable udt = adapter.GetDataByID(id);
                    //Validar que existe
                    if (udt.Count == 1)
                    {
                        var result = MessageBox.Show("Se eliminará el administrador del sistema. Estas seguro que quieres continuar? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            //Borra administrador
                            adapter.DeleteAdmi(id, admi);
                            txtID.Clear();

                            tblUsuariosDataTable rcc = adapter.GetDataByAdmi(admi);
                            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
                            borrarAdmi.LocalReport.DataSources.Clear();
                            borrarAdmi.LocalReport.DataSources.Add(rds);

                            this.borrarAdmi.RefreshReport();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Administrador no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
