namespace CoreBankApp.Forms
{
    partial class frmReporteUsuarios
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
            this.reporteUsuarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteUsuarios
            // 
            this.reporteUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteUsuarios.Location = new System.Drawing.Point(0, 0);
            this.reporteUsuarios.Name = "reporteUsuarios";
            this.reporteUsuarios.ServerReport.BearerToken = null;
            this.reporteUsuarios.ShowToolBar = false;
            this.reporteUsuarios.Size = new System.Drawing.Size(800, 450);
            this.reporteUsuarios.TabIndex = 0;
            // 
            // frmReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteUsuarios);
            this.Name = "frmReporteUsuarios";
            this.ShowIcon = false;
            this.Text = "Reporte Usuarios-Clientes";
            this.Load += new System.EventHandler(this.frmReporteUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteUsuarios;
    }
}