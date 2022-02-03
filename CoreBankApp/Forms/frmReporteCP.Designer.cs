namespace CoreBankApp.Forms
{
    partial class frmReporteCP
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
            this.reportCP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportCP
            // 
            this.reportCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportCP.Location = new System.Drawing.Point(0, 0);
            this.reportCP.Name = "reportCP";
            this.reportCP.ServerReport.BearerToken = null;
            this.reportCP.ShowToolBar = false;
            this.reportCP.Size = new System.Drawing.Size(800, 450);
            this.reportCP.TabIndex = 0;
            // 
            // frmReporteCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportCP);
            this.Name = "frmReporteCP";
            this.ShowIcon = false;
            this.Text = "Cliente-Prestamo";
            this.Load += new System.EventHandler(this.frmReporteCP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportCP;
    }
}