namespace CapaPresentacion
{
    partial class Realizar_Movimiento
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
            this.CboBanco_Movimiento = new System.Windows.Forms.ComboBox();
            this.Cbo_Cuenta_Movimiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.TxtTipo_Cuenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBanco_Cuenta = new System.Windows.Forms.TextBox();
            this.TxtNombre_Cuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumero_Cuenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnRealizar = new System.Windows.Forms.Button();
            this.DtpFecha_Movimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboBanco_Movimiento
            // 
            this.CboBanco_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBanco_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBanco_Movimiento.FormattingEnabled = true;
            this.CboBanco_Movimiento.Location = new System.Drawing.Point(189, 57);
            this.CboBanco_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.CboBanco_Movimiento.Name = "CboBanco_Movimiento";
            this.CboBanco_Movimiento.Size = new System.Drawing.Size(160, 24);
            this.CboBanco_Movimiento.TabIndex = 0;
            this.CboBanco_Movimiento.SelectedIndexChanged += new System.EventHandler(this.CboBanco_Movimiento_SelectedIndexChanged);
            // 
            // Cbo_Cuenta_Movimiento
            // 
            this.Cbo_Cuenta_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Cuenta_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Cuenta_Movimiento.FormattingEnabled = true;
            this.Cbo_Cuenta_Movimiento.Location = new System.Drawing.Point(599, 60);
            this.Cbo_Cuenta_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Cuenta_Movimiento.Name = "Cbo_Cuenta_Movimiento";
            this.Cbo_Cuenta_Movimiento.Size = new System.Drawing.Size(160, 24);
            this.Cbo_Cuenta_Movimiento.TabIndex = 1;
            this.Cbo_Cuenta_Movimiento.SelectedIndexChanged += new System.EventHandler(this.Cbo_Cuenta_Movimiento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnCerrar);
            this.groupBox1.Controls.Add(this.BtnConfirmar);
            this.groupBox1.Controls.Add(this.TxtTipo_Cuenta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TxtBanco_Cuenta);
            this.groupBox1.Controls.Add(this.TxtNombre_Cuenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtSaldo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNumero_Cuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboBanco_Movimiento);
            this.groupBox1.Controls.Add(this.Cbo_Cuenta_Movimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(155, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(787, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(30, 257);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 28);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.Location = new System.Drawing.Point(189, 207);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(92, 28);
            this.BtnConfirmar.TabIndex = 12;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // TxtTipo_Cuenta
            // 
            this.TxtTipo_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipo_Cuenta.Location = new System.Drawing.Point(599, 242);
            this.TxtTipo_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTipo_Cuenta.Name = "TxtTipo_Cuenta";
            this.TxtTipo_Cuenta.ReadOnly = true;
            this.TxtTipo_Cuenta.Size = new System.Drawing.Size(132, 22);
            this.TxtTipo_Cuenta.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(441, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tipo de Cuenta";
            // 
            // TxtBanco_Cuenta
            // 
            this.TxtBanco_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBanco_Cuenta.Location = new System.Drawing.Point(599, 201);
            this.TxtBanco_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBanco_Cuenta.Name = "TxtBanco_Cuenta";
            this.TxtBanco_Cuenta.ReadOnly = true;
            this.TxtBanco_Cuenta.Size = new System.Drawing.Size(132, 22);
            this.TxtBanco_Cuenta.TabIndex = 9;
            // 
            // TxtNombre_Cuenta
            // 
            this.TxtNombre_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Cuenta.Location = new System.Drawing.Point(599, 168);
            this.TxtNombre_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre_Cuenta.Name = "TxtNombre_Cuenta";
            this.TxtNombre_Cuenta.ReadOnly = true;
            this.TxtNombre_Cuenta.Size = new System.Drawing.Size(132, 22);
            this.TxtNombre_Cuenta.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(441, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Banco";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombre";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSaldo.Location = new System.Drawing.Point(189, 132);
            this.TxtSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.ReadOnly = true;
            this.TxtSaldo.Size = new System.Drawing.Size(132, 22);
            this.TxtSaldo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saldo";
            // 
            // TxtNumero_Cuenta
            // 
            this.TxtNumero_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero_Cuenta.Location = new System.Drawing.Point(599, 132);
            this.TxtNumero_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero_Cuenta.Name = "TxtNumero_Cuenta";
            this.TxtNumero_Cuenta.ReadOnly = true;
            this.TxtNumero_Cuenta.Size = new System.Drawing.Size(132, 22);
            this.TxtNumero_Cuenta.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnRealizar);
            this.groupBox2.Controls.Add(this.DtpFecha_Movimiento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CboTipo_Movimiento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtMonto);
            this.groupBox2.Location = new System.Drawing.Point(155, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(787, 201);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // BtnRealizar
            // 
            this.BtnRealizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnRealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRealizar.Location = new System.Drawing.Point(582, 124);
            this.BtnRealizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRealizar.Name = "BtnRealizar";
            this.BtnRealizar.Size = new System.Drawing.Size(100, 28);
            this.BtnRealizar.TabIndex = 5;
            this.BtnRealizar.Text = "Realizar";
            this.BtnRealizar.UseVisualStyleBackColor = false;
            this.BtnRealizar.Click += new System.EventHandler(this.BtnRealizar_Click);
            // 
            // DtpFecha_Movimiento
            // 
            this.DtpFecha_Movimiento.Enabled = false;
            this.DtpFecha_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha_Movimiento.Location = new System.Drawing.Point(494, 23);
            this.DtpFecha_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.DtpFecha_Movimiento.Name = "DtpFecha_Movimiento";
            this.DtpFecha_Movimiento.Size = new System.Drawing.Size(265, 22);
            this.DtpFecha_Movimiento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de Movimiento";
            // 
            // CboTipo_Movimiento
            // 
            this.CboTipo_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo_Movimiento.FormattingEnabled = true;
            this.CboTipo_Movimiento.Location = new System.Drawing.Point(283, 64);
            this.CboTipo_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo_Movimiento.Name = "CboTipo_Movimiento";
            this.CboTipo_Movimiento.Size = new System.Drawing.Size(160, 24);
            this.CboTipo_Movimiento.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Monto";
            // 
            // TxtMonto
            // 
            this.TxtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonto.Location = new System.Drawing.Point(283, 130);
            this.TxtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.ShortcutsEnabled = false;
            this.TxtMonto.Size = new System.Drawing.Size(132, 22);
            this.TxtMonto.TabIndex = 0;
            this.TxtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(150, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 29);
            this.label10.TabIndex = 8;
            this.label10.Text = "Realizar Movimiento";
            // 
            // Realizar_Movimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1106, 660);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Realizar_Movimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento";
            this.Load += new System.EventHandler(this.Movimiento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboBanco_Movimiento;
        private System.Windows.Forms.ComboBox Cbo_Cuenta_Movimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRealizar;
        private System.Windows.Forms.DateTimePicker DtpFecha_Movimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTipo_Movimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtNumero_Cuenta;
        private System.Windows.Forms.TextBox TxtBanco_Cuenta;
        private System.Windows.Forms.TextBox TxtNombre_Cuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtTipo_Cuenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label10;
    }
}