namespace CoreBankApp.Forms
{
    partial class frmReportePP
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
            this.reportePP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportePP
            // 
            this.reportePP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportePP.Location = new System.Drawing.Point(0, 0);
            this.reportePP.Name = "reportePP";
            this.reportePP.ServerReport.BearerToken = null;
            this.reportePP.ShowToolBar = false;
            this.reportePP.Size = new System.Drawing.Size(800, 450);
            this.reportePP.TabIndex = 0;
            // 
            // frmReportePP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportePP);
            this.Name = "frmReportePP";
            this.ShowIcon = false;
            this.Text = "Reporte de pagos de prestamos";
            this.Load += new System.EventHandler(this.frmReportePP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportePP;
    }
}