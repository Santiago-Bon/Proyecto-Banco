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
    public partial class Cuenta : Form
    {
        CN_Tipo_Cuenta oCN_Tipo_Cuenta = new CN_Tipo_Cuenta();
        CN_Banco oCN_Banco = new CN_Banco();
        CN_Cuenta oCN_Cuenta = new CN_Cuenta();
        CN_Validaciones validaciones = new CN_Validaciones();

        bool Editar = false;

        public Cuenta()
        {
            InitializeComponent();
        }



        private void Cuenta_Load(object sender, EventArgs e)
        {
            BuscarBanco();
            BuscarBancoCombo();
            BuscarTipo_Cuenta();
            BuscarTipo_CuentaCombo();
        }




        #region Mis métodos

        private void BuscarCuenta(int idbanco)
        {
            CboCuenta.DataSource = oCN_Cuenta.BuscarCuenta(idbanco);
            CboCuenta.DisplayMember = "nombre";
            CboCuenta.ValueMember = "numero";
            CboCuenta.SelectedIndex = -1;
        }

        private void BuscarBanco()
        {
            Cbo_Banco.DataSource = oCN_Banco.BuscarBanco();
            Cbo_Banco.DisplayMember = "nombre";
            Cbo_Banco.ValueMember = "id";
            Cbo_Banco.SelectedIndex = -1;
        }

        private void BuscarBancoCombo()
        {
            CboBanco.DataSource = oCN_Banco.BuscarBanco();
            CboBanco.DisplayMember = "nombre";
            CboBanco.ValueMember = "id";
            CboBanco.SelectedIndex = -1;
        }

        private void BuscarTipo_Cuenta()
        {
            CboTipo_Cuenta.DataSource = oCN_Tipo_Cuenta.BuscarTipo_Cuenta();
            CboTipo_Cuenta.DisplayMember = "nombre";
            CboTipo_Cuenta.ValueMember = "id";
            CboTipo_Cuenta.SelectedIndex = -1;
        }

        private void BuscarTipo_CuentaCombo()
        {
            CboTipoCuenta.DataSource = oCN_Tipo_Cuenta.BuscarTipo_Cuenta();
            CboTipoCuenta.DisplayMember = "nombre";
            CboTipoCuenta.ValueMember = "id";
            CboTipoCuenta.SelectedIndex = -1;
        }

        private void VerCuenta()
        {
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VerCuenta(cuenta);
        }

        private void VerCuenta2()
        {
            CE_Banco banco = new CE_Banco();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VerCuenta2(banco);
        }

        private void VerCuenta3()
        {
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();
            CE_Banco banco = new CE_Banco();

            tpcCuenta.id = Convert.ToInt32(CboTipoCuenta.SelectedValue);
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VerCuenta3(banco, tpcCuenta);
        }

        private void VerCuenta4()
        {
            CE_Cuenta cuenta = new CE_Cuenta();
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();
            CE_Banco banco = new CE_Banco();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            tpcCuenta.id = Convert.ToInt32(CboTipoCuenta.SelectedValue);
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VerCuenta4(banco, tpcCuenta, cuenta);
        }

        private void VerCuenta5()
        {
            CE_Tipo_Cuenta tpcCuenta = new CE_Tipo_Cuenta();

            tpcCuenta.id = Convert.ToInt32(CboTipoCuenta.SelectedValue);
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VerCuenta5(tpcCuenta);
        }

        private void VIsualizarCuenta()
        {
            DgvGestion_Cuentas.DataSource = oCN_Cuenta.VisualizarCuenta();
        }


        private void Limpiar()
        {
            TxtNumero_Cuenta.Clear();
            TxtNombre_Cuenta.Clear();
            TxtSaldo_Cuenta.Clear();
            CboTipo_Cuenta.SelectedIndex = -1;
            Cbo_Banco.SelectedIndex = -1;
        }

        private void LimpiarCombo()
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
            CboTipoCuenta.SelectedIndex = -1;
        }

        #endregion



        private void BtnEditar_Click(object sender, EventArgs e)
        {

            if (DgvGestion_Cuentas.SelectedRows.Count > 0) //Si en el datagridview el conteo de la selección de filas > 0
            {
                Cbo_Banco.Enabled = false;
                CboTipo_Cuenta.Enabled = false;
                TxtNumero_Cuenta.Enabled = false;
                BtnEliminar.Enabled = false;
                Editar = true;

                Cbo_Banco.Text = DgvGestion_Cuentas.CurrentRow.Cells["Banco"].Value.ToString();
                TxtNumero_Cuenta.Text = DgvGestion_Cuentas.CurrentRow.Cells["Número"].Value.ToString();
                TxtSaldo_Cuenta.Text = DgvGestion_Cuentas.CurrentRow.Cells["Saldo"].Value.ToString();
                CboTipo_Cuenta.Text = DgvGestion_Cuentas.CurrentRow.Cells["Tipo de Cuenta"].Value.ToString();
                TxtNombre_Cuenta.Text = DgvGestion_Cuentas.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }



        private void BtnCrear_Cuenta_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                CE_Cuenta cuenta = new CE_Cuenta();

                if (TxtNumero_Cuenta.Text != string.Empty &
                    TxtNombre_Cuenta.Text != string.Empty &
                    CboTipo_Cuenta.SelectedIndex != -1 &
                    Cbo_Banco.SelectedIndex != -1)
                {
                    cuenta.numero_cuenta = TxtNumero_Cuenta.Text;
                    cuenta.id_banco = Convert.ToInt32(Cbo_Banco.SelectedValue);
                    cuenta.nombre = TxtNombre_Cuenta.Text;

                    if (oCN_Cuenta.BuscarNumeroCuenta(cuenta) == false)
                    {
                        cuenta.id_tipo_cuenta = Convert.ToInt32(CboTipo_Cuenta.SelectedValue);
                        cuenta.saldo = 0;

                        oCN_Cuenta.InsertarCuenta(cuenta);
                        BuscarBancoCombo();
                        Limpiar();
                        VIsualizarCuenta();
                        MessageBox.Show("Se creó tu cuenta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Cuenta ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
            else
            {
                CE_Cuenta cuenta = new CE_Cuenta();

                if (TxtNumero_Cuenta.Text != string.Empty &
                    TxtNombre_Cuenta.Text != string.Empty &
                    CboTipo_Cuenta.SelectedIndex != -1 &
                    Cbo_Banco.SelectedIndex != -1)
                {
                    cuenta.numero_cuenta = TxtNumero_Cuenta.Text;
                    cuenta.nombre = TxtNombre_Cuenta.Text;
                    cuenta.id_banco = Convert.ToInt32(Cbo_Banco.SelectedValue);

                    if (oCN_Cuenta.BuscarNumeroCuentaEditar(cuenta) == false)
                    {
                        oCN_Cuenta.EditarCuenta(cuenta);
                        BuscarBancoCombo();
                        Editar = false;
                        Limpiar();
                        VIsualizarCuenta();
                        Cbo_Banco.Enabled = true;
                        CboTipo_Cuenta.Enabled = true;
                        TxtNumero_Cuenta.Enabled = true;
                        BtnEliminar.Enabled = true;
                        MessageBox.Show("Se editó tu cuenta correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Cuenta ya existe");
                    }
                }
                else
                {
                    MessageBox.Show("Error ingrese los datos");
                }
            }
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvGestion_Cuentas.SelectedRows.Count > 0) //Si en el datagridview el conteo de la selección de filas > 0
            {
                if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje de verificación al usuario para proceder a eliminar
                {
                    CE_Cuenta cuenta = new CE_Cuenta();

                    cuenta.numero_cuenta = DgvGestion_Cuentas.CurrentRow.Cells["Número"].Value.ToString();
                    oCN_Cuenta.EliminarCuenta(cuenta);
                    VIsualizarCuenta();
                    BuscarBancoCombo();
                    MessageBox.Show("Se eliminó tu cuenta correctamente");
                }
                else
                {
                    MessageBox.Show("Se canceló la eliminación");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }

            private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Cbo_Banco.Enabled = true;
            CboTipo_Cuenta.Enabled = true;
            TxtNumero_Cuenta.Enabled = true;
            BtnEliminar.Enabled = true;
            Editar = false;
        }

        private void CboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CboCuenta.SelectedIndex = -1;
            if (CboBanco.SelectedItem != null)
            {
                if (int.TryParse(CboBanco.SelectedValue.ToString(), out int idbanco))
                {
                    BuscarCuenta(idbanco);
                }
            }
        }

        private void BtnVer_Todas_Click(object sender, EventArgs e)
        {
            VIsualizarCuenta();
        }


        private void BtnVer_Cuenta_Click(object sender, EventArgs e)
        {
            if (CboBanco.SelectedIndex == -1 &
                CboCuenta.SelectedIndex == -1 &
                CboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1 &
                CboTipoCuenta.SelectedIndex != -1)
            {
                VerCuenta4();
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1)
            {
                VerCuenta();
            }
            else if (CboBanco.SelectedIndex != -1 &
                    CboTipoCuenta.SelectedIndex != -1)
            {
                VerCuenta3();
            }
            else if (CboBanco.SelectedIndex != -1 &
                    CboCuenta.SelectedIndex == -1)
            {
                VerCuenta2();
            }
            else if (CboBanco.SelectedIndex == -1 &
                    CboCuenta.SelectedIndex == -1)
            {
                VerCuenta5();
            }
            else
            {
                MessageBox.Show("Seleccione un banco");
            }
        }

        private void BtnCancelarCombo_Click(object sender, EventArgs e)
        {
            LimpiarCombo();
        }

        private void BtnLimpiar_Banco_Click(object sender, EventArgs e)
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
        }

        private void BtnLimpiar_Cuenta_Click(object sender, EventArgs e)
        {
            CboCuenta.SelectedIndex = -1;

        }

        private void BtnLimpiar_Tipo_Cuenta_Click(object sender, EventArgs e)
        {
            CboTipoCuenta.SelectedIndex = -1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DgvGestion_Cuentas.DataSource = tabla;
        }


        //Validaciones


        private void TxtNumero_Cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }

        private void TxtNombre_Cuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloLetras(e);
        }
    }
}











