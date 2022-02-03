namespace CoreBankApp.Forms
{
    partial class frmReporteCT
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
            this.reportCT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportCT
            // 
            this.reportCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportCT.Location = new System.Drawing.Point(0, 0);
            this.reportCT.Name = "reportCT";
            this.reportCT.ServerReport.BearerToken = null;
            this.reportCT.ShowToolBar = false;
            this.reportCT.Size = new System.Drawing.Size(800, 450);
            this.reportCT.TabIndex = 0;
            // 
            // frmReporteCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportCT);
            this.Name = "frmReporteCT";
            this.ShowIcon = false;
            this.Text = "Cliente-Transaccion";
            this.Load += new System.EventHandler(this.frmReporteCT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportCT;
    }
}