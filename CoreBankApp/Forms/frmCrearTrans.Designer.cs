namespace CoreBankApp.Forms
{
    partial class frmCrearTrans
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdr = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombrep = new System.Windows.Forms.TextBox();
            this.txtPreciop = new System.Windows.Forms.TextBox();
            this.txtIdCuentaE = new System.Windows.Forms.TextBox();
            this.txtIdCuentaR = new System.Windows.Forms.TextBox();
            this.btnRealizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBalanceE = new System.Windows.Forms.TextBox();
            this.txtBalanceR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula del emisor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Transaccion [ C - D ]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio del producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id cuenta emisora:";
            // 
            // txtIdr
            // 
            this.txtIdr.AutoSize = true;
            this.txtIdr.Location = new System.Drawing.Point(117, 325);
            this.txtIdr.Name = "txtIdr";
            this.txtIdr.Size = new System.Drawing.Size(103, 13);
            this.txtIdr.TabIndex = 5;
            this.txtIdr.Text = "Id cuenta receptora:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(229, 98);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(136, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(229, 193);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(136, 20);
            this.txtTipo.TabIndex = 4;
            // 
            // txtNombrep
            // 
            this.txtNombrep.Location = new System.Drawing.Point(226, 234);
            this.txtNombrep.Name = "txtNombrep";
            this.txtNombrep.Size = new System.Drawing.Size(136, 20);
            this.txtNombrep.TabIndex = 5;
            // 
            // txtPreciop
            // 
            this.txtPreciop.Location = new System.Drawing.Point(226, 277);
            this.txtPreciop.Name = "txtPreciop";
            this.txtPreciop.Size = new System.Drawing.Size(136, 20);
            this.txtPreciop.TabIndex = 6;
            // 
            // txtIdCuentaE
            // 
            this.txtIdCuentaE.Location = new System.Drawing.Point(229, 50);
            this.txtIdCuentaE.Name = "txtIdCuentaE";
            this.txtIdCuentaE.Size = new System.Drawing.Size(136, 20);
            this.txtIdCuentaE.TabIndex = 2;
            // 
            // txtIdCuentaR
            // 
            this.txtIdCuentaR.Location = new System.Drawing.Point(229, 322);
            this.txtIdCuentaR.Name = "txtIdCuentaR";
            this.txtIdCuentaR.Size = new System.Drawing.Size(136, 20);
            this.txtIdCuentaR.TabIndex = 7;
            // 
            // btnRealizar
            // 
            this.btnRealizar.Location = new System.Drawing.Point(464, 146);
            this.btnRealizar.Name = "btnRealizar";
            this.btnRealizar.Size = new System.Drawing.Size(104, 61);
            this.btnRealizar.TabIndex = 8;
            this.btnRealizar.Text = "Realizar transacción";
            this.btnRealizar.UseVisualStyleBackColor = true;
            this.btnRealizar.Click += new System.EventHandler(this.btnRealizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(617, 146);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 61);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Balance Receptor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Balance Emisor:";
            // 
            // txtBalanceE
            // 
            this.txtBalanceE.Location = new System.Drawing.Point(229, 146);
            this.txtBalanceE.Name = "txtBalanceE";
            this.txtBalanceE.Size = new System.Drawing.Size(132, 20);
            this.txtBalanceE.TabIndex = 12;
            // 
            // txtBalanceR
            // 
            this.txtBalanceR.Location = new System.Drawing.Point(229, 365);
            this.txtBalanceR.Name = "txtBalanceR";
            this.txtBalanceR.Size = new System.Drawing.Size(136, 20);
            this.txtBalanceR.TabIndex = 13;
            // 
            // frmCrearTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBalanceR);
            this.Controls.Add(this.txtBalanceE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRealizar);
            this.Controls.Add(this.txtIdCuentaR);
            this.Controls.Add(this.txtIdCuentaE);
            this.Controls.Add(this.txtPreciop);
            this.Controls.Add(this.txtNombrep);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtIdr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearTrans";
            this.ShowIcon = false;
            this.Text = "Hacer transacción";
            this.Load += new System.EventHandler(this.frmCrearTrans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtIdr;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombrep;
        private System.Windows.Forms.TextBox txtPreciop;
        private System.Windows.Forms.TextBox txtIdCuentaE;
        private System.Windows.Forms.TextBox txtIdCuentaR;
        private System.Windows.Forms.Button btnRealizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBalanceE;
        private System.Windows.Forms.TextBox txtBalanceR;
    }
}