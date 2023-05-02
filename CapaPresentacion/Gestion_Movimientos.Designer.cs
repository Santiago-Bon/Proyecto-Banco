namespace CapaPresentacion
{
    partial class Gestion_Movimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvGestion_movimientos = new System.Windows.Forms.DataGridView();
            this.BtnEliminar_Movimiento = new System.Windows.Forms.Button();
            this.BtnConsultar_Movimiento = new System.Windows.Forms.Button();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.TxtBanco = new System.Windows.Forms.TextBox();
            this.TxtTipo_Movimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboTipo_Movimiento = new System.Windows.Forms.ComboBox();
            this.BtnLimpiar_Cuenta = new System.Windows.Forms.Button();
            this.BtnCancelar_Combo = new System.Windows.Forms.Button();
            this.BtnLimpiar_Tipo_Movimiento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnLimpiar_Banco = new System.Windows.Forms.Button();
            this.CboCuenta = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CboBanco = new System.Windows.Forms.ComboBox();
            this.BtnVer_Todos = new System.Windows.Forms.Button();
            this.BtnVer_Movimientos = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestion_movimientos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvGestion_movimientos
            // 
            this.DgvGestion_movimientos.AllowUserToAddRows = false;
            this.DgvGestion_movimientos.AllowUserToResizeColumns = false;
            this.DgvGestion_movimientos.AllowUserToResizeRows = false;
            this.DgvGestion_movimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGestion_movimientos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGestion_movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGestion_movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGestion_movimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvGestion_movimientos.Location = new System.Drawing.Point(74, 364);
            this.DgvGestion_movimientos.Name = "DgvGestion_movimientos";
            this.DgvGestion_movimientos.ReadOnly = true;
            this.DgvGestion_movimientos.RowHeadersWidth = 51;
            this.DgvGestion_movimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvGestion_movimientos.RowTemplate.Height = 24;
            this.DgvGestion_movimientos.Size = new System.Drawing.Size(944, 201);
            this.DgvGestion_movimientos.TabIndex = 0;
            // 
            // BtnEliminar_Movimiento
            // 
            this.BtnEliminar_Movimiento.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar_Movimiento.Location = new System.Drawing.Point(18, 200);
            this.BtnEliminar_Movimiento.Name = "BtnEliminar_Movimiento";
            this.BtnEliminar_Movimiento.Size = new System.Drawing.Size(109, 32);
            this.BtnEliminar_Movimiento.TabIndex = 1;
            this.BtnEliminar_Movimiento.Text = "Eliminar";
            this.BtnEliminar_Movimiento.UseVisualStyleBackColor = false;
            this.BtnEliminar_Movimiento.Click += new System.EventHandler(this.TxtEliminar_Movimiento_Click);
            // 
            // BtnConsultar_Movimiento
            // 
            this.BtnConsultar_Movimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnConsultar_Movimiento.Location = new System.Drawing.Point(216, 200);
            this.BtnConsultar_Movimiento.Name = "BtnConsultar_Movimiento";
            this.BtnConsultar_Movimiento.Size = new System.Drawing.Size(109, 32);
            this.BtnConsultar_Movimiento.TabIndex = 2;
            this.BtnConsultar_Movimiento.Text = "Consultar";
            this.BtnConsultar_Movimiento.UseVisualStyleBackColor = false;
            this.BtnConsultar_Movimiento.Click += new System.EventHandler(this.BtnConsultar_Movimiento_Click);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Enabled = false;
            this.DtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(318, 21);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 22);
            this.DtpFecha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(100, 69);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 7;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(100, 114);
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.ReadOnly = true;
            this.TxtMonto.Size = new System.Drawing.Size(100, 22);
            this.TxtMonto.TabIndex = 8;
            // 
            // TxtBanco
            // 
            this.TxtBanco.Location = new System.Drawing.Point(332, 114);
            this.TxtBanco.Name = "TxtBanco";
            this.TxtBanco.ReadOnly = true;
            this.TxtBanco.Size = new System.Drawing.Size(100, 22);
            this.TxtBanco.TabIndex = 12;
            // 
            // TxtTipo_Movimiento
            // 
            this.TxtTipo_Movimiento.Location = new System.Drawing.Point(418, 69);
            this.TxtTipo_Movimiento.Name = "TxtTipo_Movimiento";
            this.TxtTipo_Movimiento.ReadOnly = true;
            this.TxtTipo_Movimiento.Size = new System.Drawing.Size(100, 22);
            this.TxtTipo_Movimiento.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de Movimiento";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Location = new System.Drawing.Point(409, 200);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(109, 32);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.TxtCuenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.BtnEliminar_Movimiento);
            this.groupBox1.Controls.Add(this.TxtBanco);
            this.groupBox1.Controls.Add(this.BtnConsultar_Movimiento);
            this.groupBox1.Controls.Add(this.TxtTipo_Movimiento);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtMonto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(507, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 256);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.Location = new System.Drawing.Point(100, 27);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.ReadOnly = true;
            this.TxtCuenta.Size = new System.Drawing.Size(100, 22);
            this.TxtCuenta.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cuenta";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CboTipo_Movimiento);
            this.groupBox2.Controls.Add(this.BtnLimpiar_Cuenta);
            this.groupBox2.Controls.Add(this.BtnCancelar_Combo);
            this.groupBox2.Controls.Add(this.BtnLimpiar_Tipo_Movimiento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnLimpiar_Banco);
            this.groupBox2.Controls.Add(this.CboCuenta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CboBanco);
            this.groupBox2.Controls.Add(this.BtnVer_Todos);
            this.groupBox2.Controls.Add(this.BtnVer_Movimientos);
            this.groupBox2.Location = new System.Drawing.Point(49, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 256);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tipo de Movimiento";
            // 
            // CboTipo_Movimiento
            // 
            this.CboTipo_Movimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo_Movimiento.FormattingEnabled = true;
            this.CboTipo_Movimiento.Location = new System.Drawing.Point(196, 133);
            this.CboTipo_Movimiento.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo_Movimiento.Name = "CboTipo_Movimiento";
            this.CboTipo_Movimiento.Size = new System.Drawing.Size(160, 24);
            this.CboTipo_Movimiento.TabIndex = 32;
            // 
            // BtnLimpiar_Cuenta
            // 
            this.BtnLimpiar_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Cuenta.Location = new System.Drawing.Point(382, 88);
            this.BtnLimpiar_Cuenta.Name = "BtnLimpiar_Cuenta";
            this.BtnLimpiar_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Cuenta.TabIndex = 31;
            this.BtnLimpiar_Cuenta.Text = "X";
            this.BtnLimpiar_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Cuenta_Click);
            // 
            // BtnCancelar_Combo
            // 
            this.BtnCancelar_Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar_Combo.Location = new System.Drawing.Point(301, 205);
            this.BtnCancelar_Combo.Name = "BtnCancelar_Combo";
            this.BtnCancelar_Combo.Size = new System.Drawing.Size(103, 23);
            this.BtnCancelar_Combo.TabIndex = 26;
            this.BtnCancelar_Combo.Text = "Cancelar";
            this.BtnCancelar_Combo.UseVisualStyleBackColor = false;
            this.BtnCancelar_Combo.Click += new System.EventHandler(this.BtnCancelar_Combo_Click);
            // 
            // BtnLimpiar_Tipo_Movimiento
            // 
            this.BtnLimpiar_Tipo_Movimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Tipo_Movimiento.Location = new System.Drawing.Point(382, 133);
            this.BtnLimpiar_Tipo_Movimiento.Name = "BtnLimpiar_Tipo_Movimiento";
            this.BtnLimpiar_Tipo_Movimiento.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Tipo_Movimiento.TabIndex = 30;
            this.BtnLimpiar_Tipo_Movimiento.Text = "X";
            this.BtnLimpiar_Tipo_Movimiento.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Tipo_Movimiento.Click += new System.EventHandler(this.BtnLimpiar_Tipo_Movimiento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Cuenta";
            // 
            // BtnLimpiar_Banco
            // 
            this.BtnLimpiar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Banco.Location = new System.Drawing.Point(382, 43);
            this.BtnLimpiar_Banco.Name = "BtnLimpiar_Banco";
            this.BtnLimpiar_Banco.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Banco.TabIndex = 29;
            this.BtnLimpiar_Banco.Text = "X";
            this.BtnLimpiar_Banco.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Banco.Click += new System.EventHandler(this.BtnLimpiar_Banco_Click);
            // 
            // CboCuenta
            // 
            this.CboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCuenta.FormattingEnabled = true;
            this.CboCuenta.Location = new System.Drawing.Point(196, 88);
            this.CboCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboCuenta.Name = "CboCuenta";
            this.CboCuenta.Size = new System.Drawing.Size(160, 24);
            this.CboCuenta.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Banco";
            // 
            // CboBanco
            // 
            this.CboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBanco.FormattingEnabled = true;
            this.CboBanco.Location = new System.Drawing.Point(196, 43);
            this.CboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.CboBanco.Name = "CboBanco";
            this.CboBanco.Size = new System.Drawing.Size(160, 24);
            this.CboBanco.TabIndex = 22;
            this.CboBanco.SelectedIndexChanged += new System.EventHandler(this.CboBanco_SelectedIndexChanged);
            // 
            // BtnVer_Todos
            // 
            this.BtnVer_Todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVer_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Todos.Location = new System.Drawing.Point(184, 205);
            this.BtnVer_Todos.Name = "BtnVer_Todos";
            this.BtnVer_Todos.Size = new System.Drawing.Size(111, 23);
            this.BtnVer_Todos.TabIndex = 1;
            this.BtnVer_Todos.Text = "Ver Todos";
            this.BtnVer_Todos.UseVisualStyleBackColor = false;
            this.BtnVer_Todos.Click += new System.EventHandler(this.BtnVer_Todos_Click);
            // 
            // BtnVer_Movimientos
            // 
            this.BtnVer_Movimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVer_Movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Movimientos.Location = new System.Drawing.Point(25, 205);
            this.BtnVer_Movimientos.Name = "BtnVer_Movimientos";
            this.BtnVer_Movimientos.Size = new System.Drawing.Size(153, 23);
            this.BtnVer_Movimientos.TabIndex = 0;
            this.BtnVer_Movimientos.Text = "Ver Movimientos";
            this.BtnVer_Movimientos.UseVisualStyleBackColor = false;
            this.BtnVer_Movimientos.Click += new System.EventHandler(this.BtnVer_Movimientos_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Gestión de Movimientos";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(922, 587);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(96, 27);
            this.BtnCerrar.TabIndex = 17;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Gestion_Movimientos
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1099, 662);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvGestion_movimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_Movimientos";
            this.Load += new System.EventHandler(this.Gestion_Movimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestion_movimientos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvGestion_movimientos;
        private System.Windows.Forms.Button BtnEliminar_Movimiento;
        private System.Windows.Forms.Button BtnConsultar_Movimiento;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtBanco;
        private System.Windows.Forms.TextBox TxtTipo_Movimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnVer_Movimientos;
        private System.Windows.Forms.Button BtnVer_Todos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboCuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboBanco;
        private System.Windows.Forms.Button BtnCancelar_Combo;
        private System.Windows.Forms.TextBox TxtCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnLimpiar_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Tipo_Movimiento;
        private System.Windows.Forms.Button BtnLimpiar_Banco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboTipo_Movimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCerrar;
    }
}