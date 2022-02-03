using CoreBankApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreBankApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            //Validar que existe
            string pass = txtContra.Text.Trim();
            DBCoreEntities db = new DBCoreEntities();

            var lst = from d in db.tblUsuarios
                      where d.Usuario == txtUsuario.Text
                      && d.Contraseña == pass
                      && d.TipoUsuario == "administrador"
                      select d;

            var lst2 = from d in db.tblUsuarios
                       where d.Usuario == txtUsuario.Text
                       && d.Contraseña == pass
                       && d.TipoUsuario == "cliente"
                       select d;

            if (lst.Count() > 0)
            {
                this.Hide();
                frmPrincipal principal = new frmPrincipal();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
            }            
            else if (lst2.Count() > 0)
            {
                
                
                MessageBox.Show("Usuario no tiene acceso suficiente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContra.Clear();

            }
            else
            {
                MessageBox.Show("Usuario no existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContra.Clear();
            }


        }
    }
}
