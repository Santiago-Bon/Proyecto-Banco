namespace CapaPresentacion
{
    partial class Cuenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnGuardar_Cuenta = new System.Windows.Forms.Button();
            this.Cbo_Banco = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNumero_Cuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CboTipo_Cuenta = new System.Windows.Forms.ComboBox();
            this.TxtNombre_Cuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvGestion_Cuentas = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtSaldo_Cuenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLimpiar_Cuenta = new System.Windows.Forms.Button();
            this.BtnLimpiar_Tipo_Cuenta = new System.Windows.Forms.Button();
            this.BtnLimpiar_Banco = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.CboCuenta = new System.Windows.Forms.ComboBox();
            this.CboBanco = new System.Windows.Forms.ComboBox();
            this.BtnCancelarCombo = new System.Windows.Forms.Button();
            this.BtnVer_Cuenta = new System.Windows.Forms.Button();
            this.BtnVer_Todas = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestion_Cuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardar_Cuenta
            // 
            this.BtnGuardar_Cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardar_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_Cuenta.Location = new System.Drawing.Point(192, 196);
            this.BtnGuardar_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar_Cuenta.Name = "BtnGuardar_Cuenta";
            this.BtnGuardar_Cuenta.Size = new System.Drawing.Size(100, 28);
            this.BtnGuardar_Cuenta.TabIndex = 0;
            this.BtnGuardar_Cuenta.Text = "Guardar";
            this.BtnGuardar_Cuenta.UseVisualStyleBackColor = false;
            this.BtnGuardar_Cuenta.Click += new System.EventHandler(this.BtnCrear_Cuenta_Click);
            // 
            // Cbo_Banco
            // 
            this.Cbo_Banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Banco.FormattingEnabled = true;
            this.Cbo_Banco.Location = new System.Drawing.Point(85, 25);
            this.Cbo_Banco.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_Banco.Name = "Cbo_Banco";
            this.Cbo_Banco.Size = new System.Drawing.Size(160, 24);
            this.Cbo_Banco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Cuenta";
            // 
            // TxtNumero_Cuenta
            // 
            this.TxtNumero_Cuenta.Location = new System.Drawing.Point(17, 112);
            this.TxtNumero_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNumero_Cuenta.Name = "TxtNumero_Cuenta";
            this.TxtNumero_Cuenta.Size = new System.Drawing.Size(160, 22);
            this.TxtNumero_Cuenta.TabIndex = 4;
            this.TxtNumero_Cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_Cuenta_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de Cuenta";
            // 
            // CboTipo_Cuenta
            // 
            this.CboTipo_Cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo_Cuenta.FormattingEnabled = true;
            this.CboTipo_Cuenta.Location = new System.Drawing.Point(419, 25);
            this.CboTipo_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipo_Cuenta.Name = "CboTipo_Cuenta";
            this.CboTipo_Cuenta.Size = new System.Drawing.Size(160, 24);
            this.CboTipo_Cuenta.TabIndex = 12;
            // 
            // TxtNombre_Cuenta
            // 
            this.TxtNombre_Cuenta.Location = new System.Drawing.Point(254, 112);
            this.TxtNombre_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre_Cuenta.Name = "TxtNombre_Cuenta";
            this.TxtNombre_Cuenta.Size = new System.Drawing.Size(160, 22);
            this.TxtNombre_Cuenta.TabIndex = 16;
            this.TxtNombre_Cuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_Cuenta_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nombre de Cuenta";
            // 
            // DgvGestion_Cuentas
            // 
            this.DgvGestion_Cuentas.AllowUserToAddRows = false;
            this.DgvGestion_Cuentas.AllowUserToResizeColumns = false;
            this.DgvGestion_Cuentas.AllowUserToResizeRows = false;
            this.DgvGestion_Cuentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvGestion_Cuentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGestion_Cuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvGestion_Cuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGestion_Cuentas.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvGestion_Cuentas.Location = new System.Drawing.Point(134, 344);
            this.DgvGestion_Cuentas.Name = "DgvGestion_Cuentas";
            this.DgvGestion_Cuentas.ReadOnly = true;
            this.DgvGestion_Cuentas.RowHeadersWidth = 51;
            this.DgvGestion_Cuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvGestion_Cuentas.RowTemplate.Height = 24;
            this.DgvGestion_Cuentas.Size = new System.Drawing.Size(816, 190);
            this.DgvGestion_Cuentas.TabIndex = 17;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(17, 196);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(100, 28);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(361, 196);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 28);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(532, 196);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtSaldo_Cuenta
            // 
            this.TxtSaldo_Cuenta.Enabled = false;
            this.TxtSaldo_Cuenta.Location = new System.Drawing.Point(472, 112);
            this.TxtSaldo_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSaldo_Cuenta.Name = "TxtSaldo_Cuenta";
            this.TxtSaldo_Cuenta.Size = new System.Drawing.Size(160, 22);
            this.TxtSaldo_Cuenta.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Saldo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.TxtSaldo_Cuenta);
            this.groupBox1.Controls.Add(this.BtnGuardar_Cuenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cbo_Banco);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnEliminar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.TxtNumero_Cuenta);
            this.groupBox1.Controls.Add(this.CboTipo_Cuenta);
            this.groupBox1.Controls.Add(this.TxtNombre_Cuenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(395, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 242);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.BtnLimpiar_Cuenta);
            this.groupBox2.Controls.Add(this.BtnLimpiar_Tipo_Cuenta);
            this.groupBox2.Controls.Add(this.BtnLimpiar_Banco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CboTipoCuenta);
            this.groupBox2.Controls.Add(this.CboCuenta);
            this.groupBox2.Controls.Add(this.CboBanco);
            this.groupBox2.Controls.Add(this.BtnCancelarCombo);
            this.groupBox2.Controls.Add(this.BtnVer_Cuenta);
            this.groupBox2.Controls.Add(this.BtnVer_Todas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(41, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 242);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // BtnLimpiar_Cuenta
            // 
            this.BtnLimpiar_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Cuenta.Location = new System.Drawing.Point(319, 83);
            this.BtnLimpiar_Cuenta.Name = "BtnLimpiar_Cuenta";
            this.BtnLimpiar_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Cuenta.TabIndex = 37;
            this.BtnLimpiar_Cuenta.Text = "X";
            this.BtnLimpiar_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Cuenta_Click);
            // 
            // BtnLimpiar_Tipo_Cuenta
            // 
            this.BtnLimpiar_Tipo_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Tipo_Cuenta.Location = new System.Drawing.Point(319, 125);
            this.BtnLimpiar_Tipo_Cuenta.Name = "BtnLimpiar_Tipo_Cuenta";
            this.BtnLimpiar_Tipo_Cuenta.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Tipo_Cuenta.TabIndex = 36;
            this.BtnLimpiar_Tipo_Cuenta.Text = "X";
            this.BtnLimpiar_Tipo_Cuenta.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Tipo_Cuenta.Click += new System.EventHandler(this.BtnLimpiar_Tipo_Cuenta_Click);
            // 
            // BtnLimpiar_Banco
            // 
            this.BtnLimpiar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar_Banco.Location = new System.Drawing.Point(319, 42);
            this.BtnLimpiar_Banco.Name = "BtnLimpiar_Banco";
            this.BtnLimpiar_Banco.Size = new System.Drawing.Size(22, 24);
            this.BtnLimpiar_Banco.TabIndex = 35;
            this.BtnLimpiar_Banco.Text = "X";
            this.BtnLimpiar_Banco.UseVisualStyleBackColor = true;
            this.BtnLimpiar_Banco.Click += new System.EventHandler(this.BtnLimpiar_Banco_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tipo de Cuenta";
            // 
            // CboTipoCuenta
            // 
            this.CboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoCuenta.FormattingEnabled = true;
            this.CboTipoCuenta.Location = new System.Drawing.Point(144, 125);
            this.CboTipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboTipoCuenta.Name = "CboTipoCuenta";
            this.CboTipoCuenta.Size = new System.Drawing.Size(160, 24);
            this.CboTipoCuenta.TabIndex = 25;
            // 
            // CboCuenta
            // 
            this.CboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCuenta.FormattingEnabled = true;
            this.CboCuenta.Location = new System.Drawing.Point(144, 83);
            this.CboCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.CboCuenta.Name = "CboCuenta";
            this.CboCuenta.Size = new System.Drawing.Size(160, 24);
            this.CboCuenta.TabIndex = 28;
            // 
            // CboBanco
            // 
            this.CboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBanco.FormattingEnabled = true;
            this.CboBanco.Location = new System.Drawing.Point(144, 42);
            this.CboBanco.Margin = new System.Windows.Forms.Padding(4);
            this.CboBanco.Name = "CboBanco";
            this.CboBanco.Size = new System.Drawing.Size(160, 24);
            this.CboBanco.TabIndex = 26;
            this.CboBanco.SelectedIndexChanged += new System.EventHandler(this.CboBanco_SelectedIndexChanged);
            // 
            // BtnCancelarCombo
            // 
            this.BtnCancelarCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelarCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarCombo.Location = new System.Drawing.Point(241, 196);
            this.BtnCancelarCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelarCombo.Name = "BtnCancelarCombo";
            this.BtnCancelarCombo.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelarCombo.TabIndex = 31;
            this.BtnCancelarCombo.Text = "Cancelar";
            this.BtnCancelarCombo.UseVisualStyleBackColor = false;
            this.BtnCancelarCombo.Click += new System.EventHandler(this.BtnCancelarCombo_Click);
            // 
            // BtnVer_Cuenta
            // 
            this.BtnVer_Cuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnVer_Cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Cuenta.Location = new System.Drawing.Point(7, 196);
            this.BtnVer_Cuenta.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Cuenta.Name = "BtnVer_Cuenta";
            this.BtnVer_Cuenta.Size = new System.Drawing.Size(118, 28);
            this.BtnVer_Cuenta.TabIndex = 25;
            this.BtnVer_Cuenta.Text = "Ver Cuentas";
            this.BtnVer_Cuenta.UseVisualStyleBackColor = false;
            this.BtnVer_Cuenta.Click += new System.EventHandler(this.BtnVer_Cuenta_Click);
            // 
            // BtnVer_Todas
            // 
            this.BtnVer_Todas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnVer_Todas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer_Todas.Location = new System.Drawing.Point(133, 196);
            this.BtnVer_Todas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnVer_Todas.Name = "BtnVer_Todas";
            this.BtnVer_Todas.Size = new System.Drawing.Size(100, 28);
            this.BtnVer_Todas.TabIndex = 30;
            this.BtnVer_Todas.Text = "Ver Todas";
            this.BtnVer_Todas.UseVisualStyleBackColor = false;
            this.BtnVer_Todas.Click += new System.EventHandler(this.BtnVer_Todas_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Banco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Cuenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Gestión de Cuentas";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(854, 550);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(96, 27);
            this.BtnCerrar.TabIndex = 26;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1085, 598);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvGestion_Cuentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta";
            this.Load += new System.EventHandler(this.Cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGestion_Cuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar_Cuenta;
        private System.Windows.Forms.ComboBox Cbo_Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumero_Cuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboTipo_Cuenta;
        private System.Windows.Forms.TextBox TxtNombre_Cuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvGestion_Cuentas;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtSaldo_Cuenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnCancelarCombo;
        private System.Windows.Forms.Button BtnVer_Cuenta;
        private System.Windows.Forms.Button BtnVer_Todas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboCuenta;
        private System.Windows.Forms.ComboBox CboBanco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboTipoCuenta;
        private System.Windows.Forms.Button BtnLimpiar_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Tipo_Cuenta;
        private System.Windows.Forms.Button BtnLimpiar_Banco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCerrar;
    }
}