namespace CoreBankApp.Forms
{
    partial class frmBuscarPrestamo
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
            this.buscarPrestamo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscarPrestamo
            // 
            this.buscarPrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscarPrestamo.Location = new System.Drawing.Point(0, 0);
            this.buscarPrestamo.Name = "buscarPrestamo";
            this.buscarPrestamo.ServerReport.BearerToken = null;
            this.buscarPrestamo.ShowToolBar = false;
            this.buscarPrestamo.Size = new System.Drawing.Size(800, 450);
            this.buscarPrestamo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(168, 44);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 43);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(445, 28);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(87, 42);
            this.btnTodos.TabIndex = 4;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // frmBuscarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarPrestamo);
            this.Name = "frmBuscarPrestamo";
            this.ShowIcon = false;
            this.Text = "Buscar prestamo";
            this.Load += new System.EventHandler(this.frmBuscarPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer buscarPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTodos;
    }
}