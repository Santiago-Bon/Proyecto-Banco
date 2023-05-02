namespace CapaPresentacion
{
    partial class Bancos
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
            this.label2 = new System.Windows.Forms.Label();
            this.CboBancos = new System.Windows.Forms.ComboBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEliminar_Banco = new System.Windows.Forms.Button();
            this.BtnEditar_Banco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBanco = new System.Windows.Forms.TextBox();
            this.BtnGuardar_Banco = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bancos";
            // 
            // CboBancos
            // 
            this.CboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboBancos.FormattingEnabled = true;
            this.CboBancos.Location = new System.Drawing.Point(353, 272);
            this.CboBancos.Name = "CboBancos";
            this.CboBancos.Size = new System.Drawing.Size(132, 24);
            this.CboBancos.TabIndex = 32;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(521, 174);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 28);
            this.BtnCancelar.TabIndex = 31;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEliminar_Banco
            // 
            this.BtnEliminar_Banco.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar_Banco.Location = new System.Drawing.Point(391, 174);
            this.BtnEliminar_Banco.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar_Banco.Name = "BtnEliminar_Banco";
            this.BtnEliminar_Banco.Size = new System.Drawing.Size(100, 28);
            this.BtnEliminar_Banco.TabIndex = 30;
            this.BtnEliminar_Banco.Text = "Eliminar";
            this.BtnEliminar_Banco.UseVisualStyleBackColor = false;
            this.BtnEliminar_Banco.Click += new System.EventHandler(this.BtnEliminar_Banco_Click);
            // 
            // BtnEditar_Banco
            // 
            this.BtnEditar_Banco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEditar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar_Banco.Location = new System.Drawing.Point(254, 174);
            this.BtnEditar_Banco.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar_Banco.Name = "BtnEditar_Banco";
            this.BtnEditar_Banco.Size = new System.Drawing.Size(100, 28);
            this.BtnEditar_Banco.TabIndex = 29;
            this.BtnEditar_Banco.Text = "Editar";
            this.BtnEditar_Banco.UseVisualStyleBackColor = false;
            this.BtnEditar_Banco.Click += new System.EventHandler(this.BtnEditar_Banco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Banco";
            // 
            // TxtBanco
            // 
            this.TxtBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBanco.Location = new System.Drawing.Point(353, 78);
            this.TxtBanco.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBanco.Name = "TxtBanco";
            this.TxtBanco.ShortcutsEnabled = false;
            this.TxtBanco.Size = new System.Drawing.Size(132, 22);
            this.TxtBanco.TabIndex = 27;
            this.TxtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBanco_KeyPress);
            // 
            // BtnGuardar_Banco
            // 
            this.BtnGuardar_Banco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar_Banco.Location = new System.Drawing.Point(105, 174);
            this.BtnGuardar_Banco.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuardar_Banco.Name = "BtnGuardar_Banco";
            this.BtnGuardar_Banco.Size = new System.Drawing.Size(100, 28);
            this.BtnGuardar_Banco.TabIndex = 26;
            this.BtnGuardar_Banco.Text = "Guardar";
            this.BtnGuardar_Banco.UseVisualStyleBackColor = false;
            this.BtnGuardar_Banco.Click += new System.EventHandler(this.BtnGuardar_Banco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.CboBancos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnGuardar_Banco);
            this.groupBox1.Controls.Add(this.TxtBanco);
            this.groupBox1.Controls.Add(this.BtnCancelar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnEliminar_Banco);
            this.groupBox1.Controls.Add(this.BtnEditar_Banco);
            this.groupBox1.Location = new System.Drawing.Point(160, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 384);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 29);
            this.label10.TabIndex = 35;
            this.label10.Text = "Gestión de Bancos";
            // 
            // Bancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1065, 568);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bancos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.Bancos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboBancos;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEliminar_Banco;
        private System.Windows.Forms.Button BtnEditar_Banco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBanco;
        private System.Windows.Forms.Button BtnGuardar_Banco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
    }
}