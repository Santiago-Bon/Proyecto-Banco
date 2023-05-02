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
    public partial class Realizar_Movimiento : Form
    {
        CN_Movimiento oCN_Movimiento = new CN_Movimiento();
        CN_Banco oCN_Banco = new CN_Banco();
        CN_Cuenta oCN_Cuenta = new CN_Cuenta();
        CN_Tipo_Movimiento oCN_Tipo_Movimiento = new CN_Tipo_Movimiento();
        CN_Validaciones validaciones = new CN_Validaciones();

        DataTable tabla_cuenta = new DataTable();


        public Realizar_Movimiento()
        {
            InitializeComponent();
        }



        #region Mis métodos

        private void BuscarBanco()
        {
            CboBanco_Movimiento.DataSource = oCN_Banco.BuscarBanco();
            CboBanco_Movimiento.DisplayMember = "nombre";
            CboBanco_Movimiento.ValueMember = "id";
            CboBanco_Movimiento.SelectedIndex = -1;
        }

        private void BuscarCuenta(int id_banco)
        {
            Cbo_Cuenta_Movimiento.DataSource = oCN_Cuenta.BuscarCuenta(id_banco);
            Cbo_Cuenta_Movimiento.DisplayMember = "nombre";
            Cbo_Cuenta_Movimiento.ValueMember = "numero";
            Cbo_Cuenta_Movimiento.SelectedIndex = -1;
        }


        private void BuscarTipo_Movimiento()
        {
            CboTipo_Movimiento.DataSource = oCN_Tipo_Movimiento.BuscarTipo_Movimiento();
            CboTipo_Movimiento.DisplayMember = "nombre";
            CboTipo_Movimiento.ValueMember = "id";
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        //private void TraerSaldo()
        //{
        //    CE_Cuenta saldo = new CE_Cuenta();

        //    saldo.numero_cuenta = Cbo_Cuenta_Movimiento.SelectedValue.ToString();

        //    TxtSaldo.Text = oCN_Cuenta.TraerSaldo(saldo);
        //}

        private void VerCuenta()
        {
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = Cbo_Cuenta_Movimiento.SelectedValue.ToString();
            tabla_cuenta = oCN_Cuenta.VerCuenta(cuenta);
            TxtNumero_Cuenta.Text = tabla_cuenta.Rows[0][0].ToString();
            TxtNombre_Cuenta.Text = tabla_cuenta.Rows[0][1].ToString();
            TxtSaldo.Text = tabla_cuenta.Rows[0][2].ToString();
            TxtBanco_Cuenta.Text = tabla_cuenta.Rows[0][3].ToString();
            TxtTipo_Cuenta.Text = tabla_cuenta.Rows[0][4].ToString();
        }


        private void Limpiar()
        {
            TxtNumero_Cuenta.Clear();
            TxtNombre_Cuenta.Clear();
            TxtTipo_Cuenta.Clear();
            TxtSaldo.Clear();
            TxtBanco_Cuenta.Clear();
            TxtMonto.Clear();
            CboBanco_Movimiento.SelectedIndex = -1;
            CboTipo_Movimiento.SelectedIndex = -1;
            Cbo_Cuenta_Movimiento.SelectedIndex = -1;
        }

        #endregion






        private void Movimiento_Load(object sender, EventArgs e)
        {
            BuscarBanco();
            BuscarTipo_Movimiento();
            BtnRealizar.Enabled = false;
        }

        private void CboBanco_Movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboBanco_Movimiento.SelectedItem != null)
            {
                if (int.TryParse(CboBanco_Movimiento.SelectedValue.ToString(), out int idbanco))
                {
                    BuscarCuenta(idbanco);
                    BtnRealizar.Enabled = false;
                }
            }
        }

        private void Cbo_Cuenta_Movimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnRealizar.Enabled = false;
        }


        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (CboBanco_Movimiento.SelectedIndex != -1 &
                Cbo_Cuenta_Movimiento.SelectedIndex != -1)
            {
                //TraerSaldo();
                VerCuenta();
                BtnRealizar.Enabled = true;
            }
            else if (CboBanco_Movimiento.SelectedIndex == -1 &
                Cbo_Cuenta_Movimiento.SelectedIndex != -1)
            {
                MessageBox.Show("Error seleccione un banco");

            }
            else
            {
                MessageBox.Show("Error seleccione una cuenta");
            }
        }



        private void BtnRealizar_Click(object sender, EventArgs e)
        {


            CE_Cuenta cuenta = new CE_Cuenta();
            CE_Movimiento movimiento = new CE_Movimiento();

            float nuevo_saldo = 0;


            if (TxtMonto.Text != String.Empty &
                CboBanco_Movimiento.SelectedIndex != -1 &
                Cbo_Cuenta_Movimiento.SelectedIndex != -1 &
                CboTipo_Movimiento.SelectedIndex != -1)
            {
                if (MessageBox.Show("Confirmar movimiento", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje de verificación al usuario para proceder a eliminar
                {
                    movimiento.monto = Convert.ToInt32(TxtMonto.Text);
                    movimiento.fecha = DtpFecha_Movimiento.Value;
                    movimiento.id_tipo_movimiento = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
                    movimiento.id_cuenta = Convert.ToInt32(Cbo_Cuenta_Movimiento.SelectedValue);

                    if (Convert.ToInt32(CboTipo_Movimiento.SelectedValue) == 1)
                    {
                        nuevo_saldo = Convert.ToInt32(TxtSaldo.Text) + Convert.ToInt32(TxtMonto.Text);

                        cuenta.numero_cuenta = Cbo_Cuenta_Movimiento.SelectedValue.ToString();
                        cuenta.saldo = nuevo_saldo;

                        oCN_Cuenta.ActualizarSaldo(cuenta);
                        VerCuenta();
                        oCN_Movimiento.InsertarMovimiento(movimiento);
                        CboTipo_Movimiento.SelectedIndex = -1;
                        TxtMonto.Clear();
                        MessageBox.Show("Se realizó tu movimiento correctamente");
                    }
                    else
                    {
                        if (Convert.ToInt32(tabla_cuenta.Rows[0][2]) - Convert.ToInt32(TxtMonto.Text) >= 0)
                        {
                            nuevo_saldo = Convert.ToInt32(TxtSaldo.Text) - Convert.ToInt32(TxtMonto.Text);
                            cuenta.numero_cuenta = Cbo_Cuenta_Movimiento.SelectedValue.ToString();
                            cuenta.saldo = nuevo_saldo;

                            oCN_Cuenta.ActualizarSaldo(cuenta);
                            VerCuenta();
                            oCN_Movimiento.InsertarMovimiento(movimiento);
                            CboTipo_Movimiento.SelectedIndex = -1;
                            TxtMonto.Clear();
                            MessageBox.Show("Se realizó tu movimiento correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Saldo insufiente");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Movimiento cancelado");
                }

            }
            else
            {
                MessageBox.Show("Error ingrese los datos");
            }
        }

    
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BtnRealizar.Enabled = false;
        }



        //Validaciones


        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.SoloNum(e);
        }
    }
}
