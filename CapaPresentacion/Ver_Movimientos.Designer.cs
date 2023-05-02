namespace CapaPresentacion
{
    partial class Ver_Movimientos
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
            this.label2 = new System.Windows.Forms.Label();
            this.CboCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CboBanco = new System.Windows.Forms.ComboBox();
            this.BtnVer_Movimiento = new System.Windows.Forms.Button();
            this.DgvMovimientos = new System.Windows.Forms.DataGridView();
            this.BtnVer_Todos = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CboTipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar_Banco = new System.Windows.Forms.Button();
            this.BtnLimpiar_Tipo_Movimiento = new System.Windows.Forms.Button();
            this.BtnLimpiar_Cuenta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnExportar_PDF = new System.Windows.Forms.Button();
            this.BtnExportar_Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cuenta";
            // 
            // CboCuenta
            // 
            this.CboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCuenta.FormattingEnabled = true;
            this.CboCuenta.Location = new System.Drawing.Point(279, 72);
            this.CboCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboCuenta.Name = "CboCuenta";
            this.CboCuenta.Size = new System.Drawing.Size(160, 24);
            this.CboCuenta.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Banco";
            // 
            // CboBanco
            // 
            this.CboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBanco.FormattingEnabled = true;
            this.CboBanco.Location = new System.Drawing.Point(279, 23);
            this.CboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.CboBanco.Name = "CboBanco";
            this.CboBanco.Size = new System.Drawing.Size(160, 24);
            this.CboBanco.TabIndex = 18;
            this.CboBanco.SelectedIndexChanged += new System.EventHandler(this.CboBanco_SelectedIndexChanged);
            // 
            // BtnVer_Movimiento
            // 
            this.BtnVer_Movimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVer_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Movimiento.Location = new System.Drawing.Point(26, 209);
            this.BtnVer_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Movimiento.Name = "BtnVer_Movimiento";
            this.BtnVer_Movimiento.Size = new System.Drawing.Size(151, 28);
            this.BtnVer_Movimiento.TabIndex = 17;
            this.BtnVer_Movimiento.Text = "Ver Movimientos";
            this.BtnVer_Movimiento.UseVisualStyleBackColor = false;
            this.BtnVer_Movimiento.Click += new System.EventHandler(this.BtnVer_Movimiento_Click_1);
            // 
            // DgvMovimientos
            // 
            this.DgvMovimientos.AllowUserToAddRows = false;
            this.DgvMovimientos.AllowUserToResizeColumns = false;
            this.DgvMovimientos.AllowUserToResizeRows = false;
            this.DgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMovimientos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvMovimientos.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvMovimientos.Location = new System.Drawing.Point(170, 353);
            this.DgvMovimientos.Margin = new System.Windows.Forms.Padding(4);
            this.DgvMovimientos.Name = "DgvMovimientos";
            this.DgvMovimientos.ReadOnly = true;
            this.DgvMovimientos.RowHeadersWidth = 51;
            this.DgvMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvMovimientos.Size = new System.Drawing.Size(704, 185);
            this.DgvMovimientos.TabIndex = 16;
            // 
            // BtnVer_Todos
            // 
            this.BtnVer_Todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVer_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Todos.Location = new System.Drawing.Point(204, 209);
            this.BtnVer_Todos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Todos.Name = "BtnVer_Todos";
            this.BtnVer_Todos.Size = new System.Drawing.Size(134, 28);
            this.BtnVer_Todos.TabIndex = 22;
            this.BtnVer_Todos.Text = "Ver Todos";
            this.BtnVer_Todos.UseVisualStyleBackColor = false;
            this.BtnVer_Todos.Click += new System.EventHandler(this.BtnVer_Todos_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(363, 209);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 28);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de Movimiento";
            // 
            // CboTipo_Movimiento
            // 
            this.CboTipo_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo_Movimiento.FormattingEnabled = true;
            this.CboTipo_Movimiento.Location = new System.Drawing.Point(279, 126);
            this.CboTipo_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo_Movimiento.Name = "CboTipo_Movimiento";
            this.CboTipo_Movimiento.Size = new System.Drawing.Size(160, 24);
            this.CboTipo_Movimiento.TabIndex = 24;
            // 
            // BtnLimpiar_Banco
            // 
            this.BtnLimpiar_Banco.Location = new System.Drawing.Point(475, 25);
            this.BtnLimpiar_Banco.Name = "BtnLimpiar_Banco";
            this.BtnLimpiar_Banco.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Banco.TabIndex = 26;
            this.BtnLimpiar_Banco.Text = "X";
            this.BtnLimpiar_Banco.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Banco.Click += new System.EventHandler(this.BtnLimpiar_Banco_Click);
            // 
            // BtnLimpiar_Tipo_Movimiento
            // 
            this.BtnLimpiar_Tipo_Movimiento.Location = new System.Drawing.Point(475, 126);
            this.BtnLimpiar_Tipo_Movimiento.Name = "BtnLimpiar_Tipo_Movimiento";
            this.BtnLimpiar_Tipo_Movimiento.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Tipo_Movimiento.TabIndex = 27;
            this.BtnLimpiar_Tipo_Movimiento.Text = "X";
            this.BtnLimpiar_Tipo_Movimiento.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Tipo_Movimiento.Click += new System.EventHandler(this.BtnLimpiar_Tipo_Movimiento_Click);
            // 
            // BtnLimpiar_Cuenta
            // 
            this.BtnLimpiar_Cuenta.Location = new System.Drawing.Point(475, 76);
            this.BtnLimpiar_Cuenta.Name = "BtnLimpiar_Cuenta";
            this.BtnLimpiar_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Cuenta.TabIndex = 28;
            this.BtnLimpiar_Cuenta.Text = "X";
            this.BtnLimpiar_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Cuenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Cuenta);
            this.groupBox1.Controls.Add(this.BtnVer_Movimiento);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Tipo_Movimiento);
            this.groupBox1.Controls.Add(this.CboBanco);
            this.groupBox1.Controls.Add(this.BtnLimpiar_Banco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CboCuenta);
            this.groupBox1.Controls.Add(this.CboTipo_Movimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnVer_Todos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 253);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 29);
            this.label10.TabIndex = 30;
            this.label10.Text = "Ver Mis Movimientos";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(879, 561);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(102, 33);
            this.BtnCerrar.TabIndex = 42;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnExportar_PDF
            // 
            this.BtnExportar_PDF.Location = new System.Drawing.Point(551, 561);
            this.BtnExportar_PDF.Name = "BtnExportar_PDF";
            this.BtnExportar_PDF.Size = new System.Drawing.Size(125, 33);
            this.BtnExportar_PDF.TabIndex = 41;
            this.BtnExportar_PDF.Text = "Exportar a PDF";
            this.BtnExportar_PDF.UseVisualStyleBackColor = true;
            this.BtnExportar_PDF.Click += new System.EventHandler(this.BtnExportar_PDF_Click);
            // 
            // BtnExportar_Excel
            // 
            this.BtnExportar_Excel.Location = new System.Drawing.Point(377, 561);
            this.BtnExportar_Excel.Name = "BtnExportar_Excel";
            this.BtnExportar_Excel.Size = new System.Drawing.Size(125, 33);
            this.BtnExportar_Excel.TabIndex = 40;
            this.BtnExportar_Excel.Text = "Exportar a Excel";
            this.BtnExportar_Excel.UseVisualStyleBackColor = true;
            this.BtnExportar_Excel.Click += new System.EventHandler(this.BtnExportar_Excel_Click);
            // 
            // Ver_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 637);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnExportar_PDF);
            this.Controls.Add(this.BtnExportar_Excel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ver_Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver_Movimientos";
            this.Load += new System.EventHandler(this.Ver_Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboBanco;
        private System.Windows.Forms.Button BtnVer_Movimiento;
        private System.Windows.Forms.Button BtnVer_Todos;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboTipo_Movimiento;
        private System.Windows.Forms.Button BtnLimpiar_Banco;
        private System.Windows.Forms.Button BtnLimpiar_Tipo_Movimiento;
        private System.Windows.Forms.Button BtnLimpiar_Cuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView DgvMovimientos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnExportar_PDF;
        private System.Windows.Forms.Button BtnExportar_Excel;
    }
}