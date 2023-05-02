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
    public partial class Tipo_Cuenta : Form
    {
        CN_Tipo_Cuenta oCN_Tipo_Cuenta = new CN_Tipo_Cuenta();
        CN_Validaciones validaciones = new CN_Validaciones();

        bool Editar = false;

        public Tipo_Cuenta()
        {
            InitializeComponent();
        }

        private void Tipo_Cuenta_Load(object sender, EventArgs e)
        {
            BuscarTipo_Cuenta();
        }

        #region Mis métodos
        private void BuscarTipo_Cuenta()
        {
            CboTipo_Cuenta.DataSource = oCN_Tipo_Cuenta.BuscarTipo_Cuenta();
            CboTipo_Cuenta.DisplayMember = "nombre";
            CboTipo_Cuenta.ValueMember = "id";
            CboTipo_Cuenta.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            TxtTipo_De_Cuenta.Clear();
            CboTipo_Cuenta.SelectedIndex = -1;
        }

        #endregion



        private void BtnEditar_Tipo_Cuenta_Click(object sender, EventArgs e)
        {
            if (CboTipo_Cuenta.SelectedIndex != -1)
            {
                TxtTipo_De_Cuenta.Text = CboTipo_Cuenta.Text;
                Editar = true;
                CboTipo_Cuenta.Enabled = false;
                BtnEliminar_Tipo_Cuenta.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una opción", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }



        private void BtnGuardar_Tipo_Cuenta_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                if (TxtTipo_De_Cuenta.Text != string.Empty)
                {
                    CE_Tipo_Cuenta tipo_cuenta = new CE_Tipo_Cuenta();

                    tipo_cuenta.nombre_tipo_cuenta = TxtTipo_De_Cuenta.Text;

                    if (oCN_Tipo_Cuenta.BuscarTipoCuenta(tipo_cuenta) == false)
                    {
                        oCN_Tipo_Cuenta.InsertarTipoCuenta(tipo_cuenta);
                        BuscarTipo_Cuenta();
                        Limpiar();
                        MessageBox.Show("Se ingresó el tipo de cuenta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El tipo de cuenta ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
            else
            {
                if (TxtTipo_De_Cuenta.Text != string.Empty)
                {
                    CE_Tipo_Cuenta tipo_cuenta = new CE_Tipo_Cuenta();

                    tipo_cuenta.id = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
                    tipo_cuenta.nombre_tipo_cuenta = TxtTipo_De_Cuenta.Text;

                    if (oCN_Tipo_Cuenta.BuscarTipoCuenta(tipo_cuenta) == false)
                    {
                        oCN_Tipo_Cuenta.EditarTipoCuenta(tipo_cuenta);
                        BuscarTipo_Cuenta();
                        Limpiar();
                        Editar = false;
                        CboTipo_Cuenta.Enabled = true;
                        BtnEliminar_Tipo_Cuenta.Enabled = true;
                        MessageBox.Show("Se editó el tipo de cuenta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("El tipo de cuenta ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
        }



        private void BtnEliminar_Tipo_Cuenta_Click(object sender, EventArgs e)
        {
            if (CboTipo_Cuenta.SelectedIndex != -1) //Si en el datagridview el conteo de la selección de filas > 0
            {
                if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje de verificación al usuario para proceder a eliminar
                {
                    CE_Tipo_Cuenta tipo_cuenta = new CE_Tipo_Cuenta();

                    tipo_cuenta.id = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
                    oCN_Tipo_Cuenta.EliminarTipoCuenta(tipo_cuenta);
                    BuscarTipo_Cuenta();
                    MessageBox.Show("Se eliminó el tipo de cuenta correctamente");
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
            CboTipo_Cuenta.Enabled = true;
            BtnEliminar_Tipo_Cuenta.Enabled = true;
        }

        private void TxtTipo_De_Cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }
    }
}
