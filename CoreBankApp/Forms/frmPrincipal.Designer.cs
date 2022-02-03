namespace CoreBankApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPerfilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarCuentaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUnPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTransacciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesConTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.cuentasToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.buscarUsuarioToolStripMenuItem,
            this.editarUsuarioToolStripMenuItem,
            this.editarAdministradorToolStripMenuItem,
            this.eliminarAdministradorToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // buscarUsuarioToolStripMenuItem
            // 
            this.buscarUsuarioToolStripMenuItem.Name = "buscarUsuarioToolStripMenuItem";
            this.buscarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.buscarUsuarioToolStripMenuItem.Text = "Buscar usuario";
            this.buscarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.buscarUsuarioToolStripMenuItem_Click);
            // 
            // editarUsuarioToolStripMenuItem
            // 
            this.editarUsuarioToolStripMenuItem.Name = "editarUsuarioToolStripMenuItem";
            this.editarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editarUsuarioToolStripMenuItem.Text = "Editar usuario";
            this.editarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.editarUsuarioToolStripMenuItem_Click);
            // 
            // editarAdministradorToolStripMenuItem
            // 
            this.editarAdministradorToolStripMenuItem.Name = "editarAdministradorToolStripMenuItem";
            this.editarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.editarAdministradorToolStripMenuItem.Text = "Editar administrador";
            this.editarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.editarAdministradorToolStripMenuItem_Click);
            // 
            // eliminarAdministradorToolStripMenuItem
            // 
            this.eliminarAdministradorToolStripMenuItem.Name = "eliminarAdministradorToolStripMenuItem";
            this.eliminarAdministradorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarAdministradorToolStripMenuItem.Text = "Eliminar administrador";
            this.eliminarAdministradorToolStripMenuItem.Click += new System.EventHandler(this.eliminarAdministradorToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPerfilToolStripMenuItem,
            this.buscarPerfilToolStripMenuItem1,
            this.editarPerfilToolStripMenuItem,
            this.eliminarPerfilToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.perfilToolStripMenuItem.Text = "Perfiles";
            // 
            // buscarPerfilToolStripMenuItem
            // 
            this.buscarPerfilToolStripMenuItem.Name = "buscarPerfilToolStripMenuItem";
            this.buscarPerfilToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.buscarPerfilToolStripMenuItem.Text = "Agregar perfil";
            this.buscarPerfilToolStripMenuItem.Click += new System.EventHandler(this.buscarPerfilToolStripMenuItem_Click);
            // 
            // buscarPerfilToolStripMenuItem1
            // 
            this.buscarPerfilToolStripMenuItem1.Name = "buscarPerfilToolStripMenuItem1";
            this.buscarPerfilToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.buscarPerfilToolStripMenuItem1.Text = "Buscar perfil";
            this.buscarPerfilToolStripMenuItem1.Click += new System.EventHandler(this.buscarPerfilToolStripMenuItem1_Click);
            // 
            // editarPerfilToolStripMenuItem
            // 
            this.editarPerfilToolStripMenuItem.Name = "editarPerfilToolStripMenuItem";
            this.editarPerfilToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarPerfilToolStripMenuItem.Text = "Editar perfil";
            this.editarPerfilToolStripMenuItem.Click += new System.EventHandler(this.editarPerfilToolStripMenuItem_Click);
            // 
            // eliminarPerfilToolStripMenuItem
            // 
            this.eliminarPerfilToolStripMenuItem.Name = "eliminarPerfilToolStripMenuItem";
            this.eliminarPerfilToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.eliminarPerfilToolStripMenuItem.Text = "Eliminar perfil";
            this.eliminarPerfilToolStripMenuItem.Click += new System.EventHandler(this.eliminarPerfilToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem,
            this.borrarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Editar Cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // borrarClienteToolStripMenuItem
            // 
            this.borrarClienteToolStripMenuItem.Name = "borrarClienteToolStripMenuItem";
            this.borrarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.borrarClienteToolStripMenuItem.Text = "Borrar Cliente";
            this.borrarClienteToolStripMenuItem.Click += new System.EventHandler(this.borrarClienteToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem,
            this.buscarCuentaToolStripMenuItem1,
            this.editarCuentaToolStripMenuItem,
            this.borrarCuentaToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.crearCuentaToolStripMenuItem.Text = "Crear Cuenta";
            this.crearCuentaToolStripMenuItem.Click += new System.EventHandler(this.crearCuentaToolStripMenuItem_Click);
            // 
            // buscarCuentaToolStripMenuItem1
            // 
            this.buscarCuentaToolStripMenuItem1.Name = "buscarCuentaToolStripMenuItem1";
            this.buscarCuentaToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.buscarCuentaToolStripMenuItem1.Text = "Buscar Cuenta";
            this.buscarCuentaToolStripMenuItem1.Click += new System.EventHandler(this.buscarCuentaToolStripMenuItem1_Click);
            // 
            // editarCuentaToolStripMenuItem
            // 
            this.editarCuentaToolStripMenuItem.Name = "editarCuentaToolStripMenuItem";
            this.editarCuentaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editarCuentaToolStripMenuItem.Text = "Editar Cuenta";
            this.editarCuentaToolStripMenuItem.Click += new System.EventHandler(this.editarCuentaToolStripMenuItem_Click);
            // 
            // borrarCuentaToolStripMenuItem
            // 
            this.borrarCuentaToolStripMenuItem.Name = "borrarCuentaToolStripMenuItem";
            this.borrarCuentaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.borrarCuentaToolStripMenuItem.Text = "Borrar Cuenta";
            this.borrarCuentaToolStripMenuItem.Click += new System.EventHandler(this.borrarCuentaToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUnPrestamoToolStripMenuItem,
            this.buscarPrestamoToolStripMenuItem,
            this.editarPrestamoToolStripMenuItem,
            this.borrarPrestamoToolStripMenuItem,
            this.pagarPrestamoToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // crearUnPrestamoToolStripMenuItem
            // 
            this.crearUnPrestamoToolStripMenuItem.Name = "crearUnPrestamoToolStripMenuItem";
            this.crearUnPrestamoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.crearUnPrestamoToolStripMenuItem.Text = "Crear Prestamo";
            this.crearUnPrestamoToolStripMenuItem.Click += new System.EventHandler(this.crearUnPrestamoToolStripMenuItem_Click);
            // 
            // buscarPrestamoToolStripMenuItem
            // 
            this.buscarPrestamoToolStripMenuItem.Name = "buscarPrestamoToolStripMenuItem";
            this.buscarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.buscarPrestamoToolStripMenuItem.Text = "Buscar Prestamo";
            this.buscarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.buscarPrestamoToolStripMenuItem_Click);
            // 
            // editarPrestamoToolStripMenuItem
            // 
            this.editarPrestamoToolStripMenuItem.Name = "editarPrestamoToolStripMenuItem";
            this.editarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarPrestamoToolStripMenuItem.Text = "Editar Prestamo";
            this.editarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.editarPrestamoToolStripMenuItem_Click);
            // 
            // borrarPrestamoToolStripMenuItem
            // 
            this.borrarPrestamoToolStripMenuItem.Name = "borrarPrestamoToolStripMenuItem";
            this.borrarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.borrarPrestamoToolStripMenuItem.Text = "Borrar Prestamo";
            this.borrarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.borrarPrestamoToolStripMenuItem_Click);
            // 
            // pagarPrestamoToolStripMenuItem
            // 
            this.pagarPrestamoToolStripMenuItem.Name = "pagarPrestamoToolStripMenuItem";
            this.pagarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pagarPrestamoToolStripMenuItem.Text = "Pagar Prestamo";
            this.pagarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.pagarPrestamoToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerTransacciónToolStripMenuItem,
            this.buscarTransacciónToolStripMenuItem,
            this.editarTransacciónToolStripMenuItem,
            this.eliminarTransacciónToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // hacerTransacciónToolStripMenuItem
            // 
            this.hacerTransacciónToolStripMenuItem.Name = "hacerTransacciónToolStripMenuItem";
            this.hacerTransacciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hacerTransacciónToolStripMenuItem.Text = "Hacer Transacción";
            this.hacerTransacciónToolStripMenuItem.Click += new System.EventHandler(this.hacerTransacciónToolStripMenuItem_Click);
            // 
            // buscarTransacciónToolStripMenuItem
            // 
            this.buscarTransacciónToolStripMenuItem.Name = "buscarTransacciónToolStripMenuItem";
            this.buscarTransacciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.buscarTransacciónToolStripMenuItem.Text = "Buscar Transacción";
            this.buscarTransacciónToolStripMenuItem.Click += new System.EventHandler(this.buscarTransacciónToolStripMenuItem_Click);
            // 
            // editarTransacciónToolStripMenuItem
            // 
            this.editarTransacciónToolStripMenuItem.Name = "editarTransacciónToolStripMenuItem";
            this.editarTransacciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editarTransacciónToolStripMenuItem.Text = "Editar Transacción";
            this.editarTransacciónToolStripMenuItem.Click += new System.EventHandler(this.editarTransacciónToolStripMenuItem_Click);
            // 
            // eliminarTransacciónToolStripMenuItem
            // 
            this.eliminarTransacciónToolStripMenuItem.Name = "eliminarTransacciónToolStripMenuItem";
            this.eliminarTransacciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.eliminarTransacciónToolStripMenuItem.Text = "Eliminar Transacción";
            this.eliminarTransacciónToolStripMenuItem.Click += new System.EventHandler(this.eliminarTransacciónToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesConToolStripMenuItem,
            this.clientesConPrestamosToolStripMenuItem,
            this.clientesConTransaccionesToolStripMenuItem,
            this.cuentasToolStripMenuItem1,
            this.usuariosDeClientesToolStripMenuItem,
            this.pagoDePrestamosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reporteToolStripMenuItem.Text = "Reportes";
            // 
            // clientesConToolStripMenuItem
            // 
            this.clientesConToolStripMenuItem.Name = "clientesConToolStripMenuItem";
            this.clientesConToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.clientesConToolStripMenuItem.Text = "Clientes con prestamos y transacciones";
            this.clientesConToolStripMenuItem.Click += new System.EventHandler(this.clientesConToolStripMenuItem_Click);
            // 
            // clientesConPrestamosToolStripMenuItem
            // 
            this.clientesConPrestamosToolStripMenuItem.Name = "clientesConPrestamosToolStripMenuItem";
            this.clientesConPrestamosToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.clientesConPrestamosToolStripMenuItem.Text = "Clientes con prestamos";
            this.clientesConPrestamosToolStripMenuItem.Click += new System.EventHandler(this.clientesConPrestamosToolStripMenuItem_Click);
            // 
            // clientesConTransaccionesToolStripMenuItem
            // 
            this.clientesConTransaccionesToolStripMenuItem.Name = "clientesConTransaccionesToolStripMenuItem";
            this.clientesConTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.clientesConTransaccionesToolStripMenuItem.Text = "Clientes con transacciones";
            this.clientesConTransaccionesToolStripMenuItem.Click += new System.EventHandler(this.clientesConTransaccionesToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem1
            // 
            this.cuentasToolStripMenuItem1.Name = "cuentasToolStripMenuItem1";
            this.cuentasToolStripMenuItem1.Size = new System.Drawing.Size(281, 22);
            this.cuentasToolStripMenuItem1.Text = "Cuentas";
            this.cuentasToolStripMenuItem1.Click += new System.EventHandler(this.cuentasToolStripMenuItem1_Click);
            // 
            // usuariosDeClientesToolStripMenuItem
            // 
            this.usuariosDeClientesToolStripMenuItem.Name = "usuariosDeClientesToolStripMenuItem";
            this.usuariosDeClientesToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.usuariosDeClientesToolStripMenuItem.Text = "Usuarios de clientes";
            this.usuariosDeClientesToolStripMenuItem.Click += new System.EventHandler(this.usuariosDeClientesToolStripMenuItem_Click);
            // 
            // pagoDePrestamosToolStripMenuItem
            // 
            this.pagoDePrestamosToolStripMenuItem.Name = "pagoDePrestamosToolStripMenuItem";
            this.pagoDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.pagoDePrestamosToolStripMenuItem.Text = "Pago de prestamos";
            this.pagoDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.pagoDePrestamosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conectado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Banco Batracar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPerfilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarCuentaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUnPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTransacciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesConToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesConPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesConTransaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoDePrestamosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

