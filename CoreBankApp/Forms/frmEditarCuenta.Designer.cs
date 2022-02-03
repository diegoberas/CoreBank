namespace CoreBankApp.Forms
{
    partial class frmEditarCuenta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editarCuenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNPropietario = new System.Windows.Forms.TextBox();
            this.txtNTipo = new System.Windows.Forms.TextBox();
            this.txtNMoneda = new System.Windows.Forms.TextBox();
            this.txtNBalance = new System.Windows.Forms.TextBox();
            this.txtNEstado = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(302, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Seleccione el ID de la cuenta que desea editar:";
            // 
            // editarCuenta
            // 
            this.editarCuenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.editarCuenta.Location = new System.Drawing.Point(0, 234);
            this.editarCuenta.Name = "editarCuenta";
            this.editarCuenta.ServerReport.BearerToken = null;
            this.editarCuenta.ShowToolBar = false;
            this.editarCuenta.Size = new System.Drawing.Size(1060, 284);
            this.editarCuenta.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Puede buscar el ID de la cuenta aqui:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(61, 319);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cedula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(215, 308);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(47, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Propietario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tipo ( C /D ):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Moneda (DOP / USD / EURO / JPY ):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Estado ( A / I ) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Datos Nuevos";
            // 
            // txtNPropietario
            // 
            this.txtNPropietario.Location = new System.Drawing.Point(420, 38);
            this.txtNPropietario.Name = "txtNPropietario";
            this.txtNPropietario.Size = new System.Drawing.Size(137, 20);
            this.txtNPropietario.TabIndex = 52;
            this.txtNPropietario.TextChanged += new System.EventHandler(this.txtNPropietario_TextChanged);
            // 
            // txtNTipo
            // 
            this.txtNTipo.Location = new System.Drawing.Point(420, 73);
            this.txtNTipo.Name = "txtNTipo";
            this.txtNTipo.Size = new System.Drawing.Size(137, 20);
            this.txtNTipo.TabIndex = 53;
            // 
            // txtNMoneda
            // 
            this.txtNMoneda.Location = new System.Drawing.Point(420, 105);
            this.txtNMoneda.Name = "txtNMoneda";
            this.txtNMoneda.Size = new System.Drawing.Size(137, 20);
            this.txtNMoneda.TabIndex = 54;
            // 
            // txtNBalance
            // 
            this.txtNBalance.Location = new System.Drawing.Point(420, 143);
            this.txtNBalance.Name = "txtNBalance";
            this.txtNBalance.Size = new System.Drawing.Size(137, 20);
            this.txtNBalance.TabIndex = 55;
            // 
            // txtNEstado
            // 
            this.txtNEstado.Location = new System.Drawing.Point(420, 182);
            this.txtNEstado.Name = "txtNEstado";
            this.txtNEstado.Size = new System.Drawing.Size(137, 20);
            this.txtNEstado.TabIndex = 56;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(638, 76);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 55);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(773, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 56);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmEditarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 518);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNEstado);
            this.Controls.Add(this.txtNBalance);
            this.Controls.Add(this.txtNMoneda);
            this.Controls.Add(this.txtNTipo);
            this.Controls.Add(this.txtNPropietario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.editarCuenta);
            this.Controls.Add(this.textBox1);
            this.Name = "frmEditarCuenta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cuenta";
            this.Load += new System.EventHandler(this.frmEditarCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.Reporting.WinForms.ReportViewer editarCuenta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNPropietario;
        private System.Windows.Forms.TextBox txtNTipo;
        private System.Windows.Forms.TextBox txtNMoneda;
        private System.Windows.Forms.TextBox txtNBalance;
        private System.Windows.Forms.TextBox txtNEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}