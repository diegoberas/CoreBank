namespace CoreBankApp.Forms
{
    partial class frmPagoPrestamo
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
            this.pagoPrestamo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pagoPrestamo
            // 
            this.pagoPrestamo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagoPrestamo.Location = new System.Drawing.Point(0, 135);
            this.pagoPrestamo.Name = "pagoPrestamo";
            this.pagoPrestamo.ServerReport.BearerToken = null;
            this.pagoPrestamo.ShowToolBar = false;
            this.pagoPrestamo.Size = new System.Drawing.Size(800, 315);
            this.pagoPrestamo.TabIndex = 0;
            this.pagoPrestamo.Load += new System.EventHandler(this.pagoPrestamo_Load);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(226, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Puede buscar el ID del prestamo aqui:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cedula del cliente:";
            // 
            // txtCedulaBuscar
            // 
            this.txtCedulaBuscar.Location = new System.Drawing.Point(127, 287);
            this.txtCedulaBuscar.Name = "txtCedulaBuscar";
            this.txtCedulaBuscar.Size = new System.Drawing.Size(128, 20);
            this.txtCedulaBuscar.TabIndex = 36;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(283, 278);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 37);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(332, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.Text = "Introduzca los datos requeridos para pagar el prestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID del prestamo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cedula del cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cantidad que desea pagar:";
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(232, 56);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(135, 20);
            this.txtIdPrestamo.TabIndex = 42;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(232, 97);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(135, 20);
            this.txtCedula.TabIndex = 43;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(232, 149);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(135, 20);
            this.txtCantidad.TabIndex = 44;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(477, 89);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(101, 57);
            this.btnPagar.TabIndex = 45;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(629, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(101, 57);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPagoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtIdPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCedulaBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pagoPrestamo);
            this.Name = "frmPagoPrestamo";
            this.ShowIcon = false;
            this.Text = "Pagar prestamo";
            this.Load += new System.EventHandler(this.frmPagoPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer pagoPrestamo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}