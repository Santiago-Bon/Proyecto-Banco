using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Bancos : Form
    {
        CN_Banco oCNBanco = new CN_Banco();
        CN_Validaciones validaciones = new CN_Validaciones();

        bool Editar = false;

        public Bancos()
        {
            InitializeComponent();
        }

        private void Bancos_Load(object sender, EventArgs e)
        {
            BuscarBanco();
        }

        #region Mis métodos

        private void BuscarBanco()
        {
            CboBancos.DataSource = oCNBanco.BuscarBanco();
            CboBancos.DisplayMember = "nombre";
            CboBancos.ValueMember = "id";
            CboBancos.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            TxtBanco.Clear();
            CboBancos.SelectedIndex = -1;
        }

        #endregion

        private void BtnEditar_Banco_Click(object sender, EventArgs e)
        {
            if (CboBancos.SelectedIndex != -1)
            {
                TxtBanco.Text = CboBancos.Text;
                Editar = true;
                CboBancos.Enabled = false;
                BtnEliminar_Banco.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una opción", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }

        private void BtnGuardar_Banco_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                if (TxtBanco.Text != string.Empty)
                {
                    CE_Banco banco = new CE_Banco();

                    banco.nombre_banco = TxtBanco.Text;

                    if (oCNBanco.BuscarBancos(banco) == false)
                    {
                        oCNBanco.InsertarBanco(banco);
                        BuscarBanco();
                        Limpiar();
                        MessageBox.Show("Se ingresó el banco correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El banco ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
            else
            {
                if (TxtBanco.Text != string.Empty)
                {
                    CE_Banco banco = new CE_Banco();

                    banco.id = Convert.ToInt32(CboBancos.SelectedValue);
                    banco.nombre_banco = TxtBanco.Text;

                    if (oCNBanco.BuscarBancosEditar(banco) == false)
                    {
                        oCNBanco.EditarBanco(banco);
                        BuscarBanco();
                        Limpiar();
                        Editar = false;
                        CboBancos.Enabled = true;
                        BtnEliminar_Banco.Enabled = true;
                        MessageBox.Show("Se editó el banco correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El banco ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
        }


        private void BtnEliminar_Banco_Click(object sender, EventArgs e)
        {
            if (CboBancos.SelectedIndex != -1) //Si en el datagridview el conteo de la selección de filas > 0
            {
                if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje de verificación al usuario para proceder a eliminar
                {
                    CE_Banco banco = new CE_Banco();

                    banco.id = Convert.ToInt32(CboBancos.SelectedValue);
                    oCNBanco.EliminarBanco(banco);
                    BuscarBanco();
                    MessageBox.Show("Se eliminó el banco correctamente");
                }
                else
                {
                    MessageBox.Show("Se canceló la eliminación");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Editar = false;
            CboBancos.Enabled = true;
            BtnEliminar_Banco.Enabled = true;
        }




        //Validaciones


        private void TxtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }
    }
}
