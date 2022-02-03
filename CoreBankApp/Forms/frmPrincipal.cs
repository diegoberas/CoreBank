using CoreBankApp.Forms;
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

namespace CoreBankApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\corebank.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abre el form
            frmAgregarCliente AgregarCliente = new frmAgregarCliente();
            AgregarCliente.MdiParent = this;
            AgregarCliente.Show();
            

        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente BuscarCliente = new frmBuscarCliente();
            BuscarCliente.MdiParent = this;
            BuscarCliente.Show();
            

        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarCliente EditarCliente = new frmEditarCliente();
            EditarCliente.MdiParent = this;
            EditarCliente.Show();
        }

        private void borrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarCliente BorrarCliente = new BorrarCliente();
            BorrarCliente.MdiParent = this;
            BorrarCliente.Show();
        }

        private void crearCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearCuenta cuenta = new frmCrearCuenta();
            cuenta.MdiParent = this;
            cuenta.Show();
        }

        private void buscarCuentaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarCuenta buscarCuenta = new frmBuscarCuenta();
            buscarCuenta.MdiParent = this;
            buscarCuenta.Show();
        }

        private void editarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarCuenta editarCuenta = new frmEditarCuenta();
            editarCuenta.MdiParent = this;
            editarCuenta.Show();
        }

        private void borrarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarCuenta borrarCuenta = new frmBorrarCuenta();
            borrarCuenta.MdiParent = this;
            borrarCuenta.Show();
        }

        private void crearUnPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearPrestamo crearPrestamo = new frmCrearPrestamo();
            crearPrestamo.MdiParent = this;
            crearPrestamo.Show();
        }

        private void buscarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarPrestamo buscarPrestamo = new frmBuscarPrestamo();
            buscarPrestamo.MdiParent = this;
            buscarPrestamo.Show();
        }

        private void editarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarPrestamo editarPrestamo = new frmEditarPrestamo();
            editarPrestamo.MdiParent = this;
            editarPrestamo.Show();
        }

        private void borrarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarPrestamo borrarPrestamo = new frmBorrarPrestamo();
            borrarPrestamo.MdiParent = this;
            borrarPrestamo.Show();
        }

        private void buscarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarPerfil agregarPerfil = new frmAgregarPerfil();
            agregarPerfil.MdiParent = this;
            agregarPerfil.Show();
        }

        private void buscarPerfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBuscarPerfil buscarPerfil = new frmBuscarPerfil();
            buscarPerfil.MdiParent = this;
            buscarPerfil.Show();
        }

        private void editarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarPerfil editarPerfil = new frmEditarPerfil();
            editarPerfil.MdiParent = this;
            editarPerfil.Show();
        }

        private void eliminarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarPerfil borrarPerfil = new frmBorrarPerfil();
            borrarPerfil.MdiParent = this;
            borrarPerfil.Show();
        }

        private void hacerTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearTrans crearTrans = new frmCrearTrans();
            crearTrans.MdiParent = this;
            crearTrans.Show();
        }

        private void buscarTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarTrans buscarTrans = new frmBuscarTrans();
            buscarTrans.MdiParent = this;
            buscarTrans.Show();
        }

        private void editarTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarTrans editarTrans = new frmEditarTrans();
            editarTrans.MdiParent = this;
            editarTrans.Show();
        }

        private void eliminarTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarTrans borrarTrans = new frmBorrarTrans();
            borrarTrans.MdiParent = this;
            borrarTrans.Show();
        }

        private void clientesConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePT reportePT = new frmReportePT();
            reportePT.MdiParent = this;
            reportePT.Show();
        }

        private void clientesConPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCP reporteCP = new frmReporteCP();
            reporteCP.MdiParent = this;
            reporteCP.Show();
        }

        private void clientesConTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCT reporteCT = new frmReporteCT();
            reporteCT.MdiParent = this;
            reporteCT.Show();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCrearUsuario crearUsuario = new frmCrearUsuario();
            crearUsuario.MdiParent = this;
            crearUsuario.Show();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarUsuario editarUsuario = new frmEditarUsuario();
            editarUsuario.MdiParent = this;
            editarUsuario.Show();
        }

        private void buscarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario buscarUsuario = new frmBuscarUsuario();
            buscarUsuario.MdiParent = this;
            buscarUsuario.Show();
        }

        private void editarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarADMI editarADMI = new frmEditarADMI();
            editarADMI.MdiParent = this;
            editarADMI.Show();
        }

        private void eliminarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrarADMI borrarADMI = new frmBorrarADMI();
            borrarADMI.MdiParent = this;
            borrarADMI.Show();
        }

        private void cuentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReporteCuenta reporteCuenta = new frmReporteCuenta();
            reporteCuenta.MdiParent = this;
            reporteCuenta.Show();
        }

        private void usuariosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUsuarios reporteUsuarios = new frmReporteUsuarios();
            reporteUsuarios.MdiParent = this;
            reporteUsuarios.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente debe existir en la base de datos para crear los otros modulos (Usuario, Perfil, Cuenta, Prestamo y Transacción).", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pagarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagoPrestamo pagoPrestamo = new frmPagoPrestamo();
            pagoPrestamo.MdiParent = this;
            pagoPrestamo.Show();
        }

        private void pagoDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePP reportePP = new frmReportePP();
            reportePP.MdiParent = this;
            reportePP.Show();
        }
    }
}
