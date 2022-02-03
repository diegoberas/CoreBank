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
    public partial class frmEditarADMI : Form
    {
        public frmEditarADMI()
        {
            InitializeComponent();
        }

        private void frmEditarADMI_Load(object sender, EventArgs e)
        {
            string admi = "administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized; //Maximizar ventana
            editarAdmi.LocalReport.ReportPath = @"C:\Users\san\source\repos\CoreBank1\CoreBankApp\ReportViewers\Usuario.rdlc";
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();
            tblUsuariosDataTable rcc = adapter.GetDataByAdmi(admi);
            ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
            editarAdmi.LocalReport.DataSources.Clear();
            editarAdmi.LocalReport.DataSources.Add(rds);
            
            this.editarAdmi.RefreshReport();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tblUsuariosTableAdapter adapter = new tblUsuariosTableAdapter();

            if (txtID.Text == "")
            {
                MessageBox.Show("Necesitas el ID del administrador que desea poder editarlo.");
            }
            else
            {

                if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtcontra.Text))
                {
                    MessageBox.Show("No se pudo actualizar. Se encontraron campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {         
                    
                        int id = int.Parse(txtID.Text);
                        string admi = "administrador";
                        tblUsuariosDataTable udt = adapter.GetDataByID(id);
                        if (udt.Count == 1)
                        {
                            try
                            {

                                adapter.UpdateAdmi(txtUsuario.Text, txtcontra.Text, id, admi ,id);
                                MessageBox.Show("Se han guardado los cambios.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtID.Clear();
                                txtcontra.Clear();
                                txtUsuario.Clear();
                                
                                tblUsuariosDataTable rcc = adapter.GetDataByAdmi(admi);
                                ReportDataSource rds = new ReportDataSource("DSU", (DataTable)rcc);
                                editarAdmi.LocalReport.DataSources.Clear();
                                editarAdmi.LocalReport.DataSources.Add(rds);

                                this.editarAdmi.RefreshReport();

                        }
                            catch (Exception)
                            {

                                MessageBox.Show("Error de formato.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtID.Clear();
                                txtcontra.Clear();                               
                                txtUsuario.Clear();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Administrador no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtID.Clear();
                            txtcontra.Clear();
                            txtUsuario.Clear();
                        }

                    
                    


                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            txtID.Clear();
            txtUsuario.Clear();
            txtcontra.Clear();

        }
    }
}
