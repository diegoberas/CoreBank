namespace CoreBankApp.Forms
{
    partial class frmBuscarUsuario
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
            this.buscarUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnAdmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscarUsuario
            // 
            this.buscarUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarUsuario.Location = new System.Drawing.Point(0, 0);
            this.buscarUsuario.Name = "buscarUsuario";
            this.buscarUsuario.ServerReport.BearerToken = null;
            this.buscarUsuario.ShowToolBar = false;
            this.buscarUsuario.Size = new System.Drawing.Size(800, 450);
            this.buscarUsuario.TabIndex = 0;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(98, 41);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cedula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(248, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 42);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(355, 30);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(81, 41);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnAdmi
            // 
            this.btnAdmi.Location = new System.Drawing.Point(661, 37);
            this.btnAdmi.Name = "btnAdmi";
            this.btnAdmi.Size = new System.Drawing.Size(127, 27);
            this.btnAdmi.TabIndex = 5;
            this.btnAdmi.Text = "Administradores";
            this.btnAdmi.UseVisualStyleBackColor = true;
            this.btnAdmi.Click += new System.EventHandler(this.btnAdmi_Click);
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdmi);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.buscarUsuario);
            this.Name = "frmBuscarUsuario";
            this.ShowIcon = false;
            this.Text = "Buscar usuario";
            this.Load += new System.EventHandler(this.frmBuscarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer buscarUsuario;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnAdmi;
    }
}