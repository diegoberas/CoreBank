namespace CoreBankApp.Forms
{
    partial class frmReporteCuenta
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
            this.reporteCuenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reporteCuenta
            // 
            this.reporteCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reporteCuenta.Location = new System.Drawing.Point(0, 0);
            this.reporteCuenta.Name = "reporteCuenta";
            this.reporteCuenta.ServerReport.BearerToken = null;
            this.reporteCuenta.ShowToolBar = false;
            this.reporteCuenta.Size = new System.Drawing.Size(800, 450);
            this.reporteCuenta.TabIndex = 0;
            // 
            // frmReporteCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reporteCuenta);
            this.Name = "frmReporteCuenta";
            this.ShowIcon = false;
            this.Text = "Reporte Cuentas";
            this.Load += new System.EventHandler(this.frmReporteCuenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporteCuenta;
    }
}