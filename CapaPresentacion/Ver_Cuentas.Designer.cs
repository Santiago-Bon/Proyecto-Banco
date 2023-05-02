namespace CapaPresentacion
{
    partial class Ver_Cuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvCuenta = new System.Windows.Forms.DataGridView();
            this.BtnVer_Cuenta = new System.Windows.Forms.Button();
            this.CboBanco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboCuenta = new System.Windows.Forms.ComboBox();
            this.BtnVer_Todas = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTipo_Cuenta = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar_Cuenta = new System.Windows.Forms.Button();
            this.BtnLimpiar_Tipo_Cuenta = new System.Windows.Forms.Button();
            this.BtnLimpiar_Banco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnExportar_Excel = new System.Windows.Forms.Button();
            this.BtnExportar_PDF = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCuenta
            // 
            this.DgvCuenta.AllowUserToAddRows = false;
            this.DgvCuenta.AllowUserToResizeColumns = false;
            this.DgvCuenta.AllowUserToResizeRows = false;
            this.DgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCuenta.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCuenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCuenta.Location = new System.Drawing.Point(179, 352);
            this.DgvCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCuenta.Name = "DgvCuenta";
            this.DgvCuenta.ReadOnly = true;
            this.DgvCuenta.RowHeadersWidth = 51;
            this.DgvCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvCuenta.Size = new System.Drawing.Size(704, 185);
            this.DgvCuenta.TabIndex = 0;
            // 
            // BtnVer_Cuenta
            // 
            this.BtnVer_Cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVer_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Cuenta.Location = new System.Drawing.Point(22, 218);
            this.BtnVer_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Cuenta.Name = "BtnVer_Cuenta";
            this.BtnVer_Cuenta.Size = new System.Drawing.Size(118, 28);
            this.BtnVer_Cuenta.TabIndex = 1;
            this.BtnVer_Cuenta.Text = "Ver Cuentas";
            this.BtnVer_Cuenta.UseVisualStyleBackColor = false;
            this.BtnVer_Cuenta.Click += new System.EventHandler(this.BtnVer_Cuenta_Click);
            // 
            // CboBanco
            // 
            this.CboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBanco.FormattingEnabled = true;
            this.CboBanco.Location = new System.Drawing.Point(275, 25);
            this.CboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.CboBanco.Name = "CboBanco";
            this.CboBanco.Size = new System.Drawing.Size(160, 24);
            this.CboBanco.TabIndex = 2;
            this.CboBanco.SelectedIndexChanged += new System.EventHandler(this.CboBanco_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cuenta";
            // 
            // CboCuenta
            // 
            this.CboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCuenta.FormattingEnabled = true;
            this.CboCuenta.Location = new System.Drawing.Point(275, 74);
            this.CboCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboCuenta.Name = "CboCuenta";
            this.CboCuenta.Size = new System.Drawing.Size(160, 24);
            this.CboCuenta.TabIndex = 4;
            // 
            // BtnVer_Todas
            // 
            this.BtnVer_Todas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVer_Todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Todas.Location = new System.Drawing.Point(203, 218);
            this.BtnVer_Todas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Todas.Name = "BtnVer_Todas";
            this.BtnVer_Todas.Size = new System.Drawing.Size(118, 28);
            this.BtnVer_Todas.TabIndex = 6;
            this.BtnVer_Todas.Text = "Ver Todas";
            this.BtnVer_Todas.UseVisualStyleBackColor = false;
            this.BtnVer_Todas.Click += new System.EventHandler(this.BtnVer_Todas_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(379, 218);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(118, 28);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Cuenta";
            // 
            // CboTipo_Cuenta
            // 
            this.CboTipo_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo_Cuenta.FormattingEnabled = true;
            this.CboTipo_Cuenta.Location = new System.Drawing.Point(275, 123);
            this.CboTipo_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo_Cuenta.Name = "CboTipo_Cuenta";
            this.CboTipo_Cuenta.Size = new System.Drawing.Size(160, 24);
            this.CboTipo_Cuenta.TabIndex = 8;
            // 
            // BtnLimpiar_Cuenta
            // 
            this.BtnLimpiar_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Cuenta.Location = new System.Drawing.Point(475, 74);
            this.BtnLimpiar_Cuenta.Name = "BtnLimpiar_Cuenta";
            this.BtnLimpiar_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Cuenta.TabIndex = 34;
            this.BtnLimpiar_Cuenta.Text = "X";
            this.BtnLimpiar_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Cuenta_Click);
            // 
            // BtnLimpiar_Tipo_Cuenta
            // 
            this.BtnLimpiar_Tipo_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Tipo_Cuenta.Location = new System.Drawing.Point(475, 123);
            this.BtnLimpiar_Tipo_Cuenta.Name = "BtnLimpiar_Tipo_Cuenta";
            this.BtnLimpiar_Tipo_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Tipo_Cuenta.TabIndex = 33;
            this.BtnLimpiar_Tipo_Cuenta.Text = "X";
            this.BtnLimpiar_Tipo_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Tipo_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Tipo_Cuenta_Click);
            // 
            // BtnLimpiar_Banco
            // 
            this.BtnLimpiar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Banco.Location = new System.Drawing.Point(475, 25);
            this.BtnLimpiar_Banco.Name = "BtnLimpiar_Banco";
            this.BtnLimpiar_Banco.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Banco.TabIndex = 32;
            this.BtnLimpiar_Banco.Text = "X";
            this.BtnLimpiar_Banco.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Banco.Click += new System.EventHandler(this.BtnLimpiar_Banco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Cuenta);
            this.groupBox1.Controls.Add(this.BtnVer_Cuenta);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Tipo_Cuenta);
            this.groupBox1.Controls.Add(this.CboBanco);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Banco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CboCuenta);
            this.groupBox1.Controls.Add(this.CboTipo_Cuenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnVer_Todas);
            this.groupBox1.Location = new System.Drawing.Point(270, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 262);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(174, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 29);
            this.label10.TabIndex = 36;
            this.label10.Text = "Ver Mis Cuentas";
            // 
            // BtnExportar_Excel
            // 
            this.BtnExportar_Excel.Location = new System.Drawing.Point(371, 574);
            this.BtnExportar_Excel.Name = "BtnExportar_Excel";
            this.BtnExportar_Excel.Size = new System.Drawing.Size(125, 33);
            this.BtnExportar_Excel.TabIndex = 37;
            this.BtnExportar_Excel.Text = "Exportar a Excel";
            this.BtnExportar_Excel.UseVisualStyleBackColor = true;
            this.BtnExportar_Excel.Click += new System.EventHandler(this.BtnExportar_Excel_Click);
            // 
            // BtnExportar_PDF
            // 
            this.BtnExportar_PDF.Location = new System.Drawing.Point(545, 574);
            this.BtnExportar_PDF.Name = "BtnExportar_PDF";
            this.BtnExportar_PDF.Size = new System.Drawing.Size(125, 33);
            this.BtnExportar_PDF.TabIndex = 38;
            this.BtnExportar_PDF.Text = "Exportar a PDF";
            this.BtnExportar_PDF.UseVisualStyleBackColor = true;
            this.BtnExportar_PDF.Click += new System.EventHandler(this.BtnExportar_PDF_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(892, 574);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(102, 33);
            this.BtnCerrar.TabIndex = 39;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Ver_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportar_PDF);
            this.Controls.Add(this.BtnExportar_Excel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvCuenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ver_Cuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Cuentas";
            this.Load += new System.EventHandler(this.Ver_Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCuenta;
        private System.Windows.Forms.Button BtnVer_Cuenta;
        private System.Windows.Forms.ComboBox CboBanco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCuenta;
        private System.Windows.Forms.Button BtnVer_Todas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTipo_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Tipo_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Banco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnExportar_Excel;
        private System.Windows.Forms.Button BtnExportar_PDF;
        private System.Windows.Forms.Button BtnCerrar;
    }
}