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
    public partial class Gestion_Movimientos : Form
    {
        CN_Banco oCNBanco = new CN_Banco();
        CN_Cuenta oCN_Cuenta = new CN_Cuenta();
        CN_Movimiento oCN_Movimiento = new CN_Movimiento();
        CN_Tipo_Movimiento oCN_Tipo_Movimiento = new CN_Tipo_Movimiento();

        public Gestion_Movimientos()
        {
            InitializeComponent();
        }

        private void Gestion_Movimientos_Load(object sender, EventArgs e)
        {
            BuscarBanco();
            BuscarTipo_Movimiento();
        }

        #region Mis métodos

        private void BuscarBanco()
        {
            CboBanco.DataSource = oCNBanco.BuscarBanco();
            CboBanco.DisplayMember = "nombre";
            CboBanco.ValueMember = "id";
            CboBanco.SelectedIndex = -1;
        }


        private void BuscarCuenta(int idbanco)
        {
            CboCuenta.DataSource = oCN_Cuenta.BuscarCuenta(idbanco);
            CboCuenta.DisplayMember = "nombre";
            CboCuenta.ValueMember = "numero";
            CboCuenta.SelectedIndex = -1;
        }


        private void BuscarTipo_Movimiento()
        {
            CboTipo_Movimiento.DataSource = oCN_Tipo_Movimiento.BuscarTipo_Movimiento();
            CboTipo_Movimiento.DisplayMember = "nombre";
            CboTipo_Movimiento.ValueMember = "id";
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        private void VerMovimiento()
        {
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VerMovimientos(cuenta);
        }

        private void VerMovimiento2()
        {
            CE_Banco banco = new CE_Banco();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VerMovimientos2(banco);
        }

        private void VerMovimiento3()
        {
            CE_Banco banco = new CE_Banco();
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();

            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VerMovimientos3(tpmMov, banco);
        }

        private void VerMovimiento4()
        {
            CE_Banco banco = new CE_Banco();
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();
            CE_Cuenta cuenta = new CE_Cuenta();

            cuenta.numero_cuenta = CboCuenta.SelectedValue.ToString();
            banco.id = Convert.ToInt32(CboBanco.SelectedValue);
            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VerMovimientos4(tpmMov, banco, cuenta);
        }

        private void VerMovimiento5()
        {
            CE_Tipo_Movimiento tpmMov = new CE_Tipo_Movimiento();

            tpmMov.id = Convert.ToInt32(CboTipo_Movimiento.SelectedValue);
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VerMovimientos5(tpmMov);
        }

        private void VisualizarMovimientos()
        {
            DgvGestion_movimientos.DataSource = oCN_Movimiento.VisualizarMovimientos();
        }

        private void Limpiar()
        {
            TxtCuenta.Clear();
            TxtId.Clear();
            TxtMonto.Clear();
            TxtBanco.Clear();
            TxtTipo_Movimiento.Clear();
            DtpFecha.Value = DateTime.Now;
        }

        private void LimpiarCombo()
        {
            CboBanco.SelectedIndex = -1;
            CboCuenta.SelectedIndex = -1;
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        #endregion

        private void TxtEliminar_Movimiento_Click(object sender, EventArgs e)
        {
            if (DgvGestion_movimientos.SelectedRows.Count > 0) //Si en el datagridview el conteo de la selección de filas > 0
            {
                if (MessageBox.Show("Seguro que quieres eliminar", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje de verificación al usuario para proceder a eliminar
                {
                    CE_Movimiento movimiento = new CE_Movimiento();

                    movimiento.id = Convert.ToInt32(DgvGestion_movimientos.CurrentRow.Cells["id"].Value);
                    oCN_Movimiento.EliminarMovimiento(movimiento);
                    VisualizarMovimientos();
                    BuscarBanco();
                    MessageBox.Show("Se eliminó tu movimiento correctamente");
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

        private void BtnConsultar_Movimiento_Click(object sender, EventArgs e)
        {
            if (DgvGestion_movimientos.SelectedRows.Count > 0) //Si en el datagridview el conteo de la selección de filas > 0
            {
                TxtCuenta.Text = DgvGestion_movimientos.CurrentRow.Cells["Cuenta"].Value.ToString();
                TxtBanco.Text = DgvGestion_movimientos.CurrentRow.Cells["Banco"].Value.ToString();
                TxtId.Text = DgvGestion_movimientos.CurrentRow.Cells["Id"].Value.ToString();
                TxtMonto.Text = DgvGestion_movimientos.CurrentRow.Cells["Monto"].Value.ToString();
                DtpFecha.Text = DgvGestion_movimientos.CurrentRow.Cells["Fecha"].Value.ToString();
                TxtTipo_Movimiento.Text = DgvGestion_movimientos.CurrentRow.Cells["Tipo de Movimiento"].Value.ToString();
                BtnEliminar_Movimiento.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una fila", "No se puede", MessageBoxButtons.OK, MessageBoxIcon.Error); //Dar el mensaje de error con un ícono
            }
        }



        private void CboBanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboBanco.SelectedItem != null)
            {
                if (int.TryParse(CboBanco.SelectedValue.ToString(), out int idbanco))
                {
                    BuscarCuenta(idbanco);
                }
            }
        }


        private void BtnVer_Movimientos_Click(object sender, EventArgs e)
        {
            if (CboBanco.SelectedIndex == -1 &
                CboCuenta.SelectedIndex == -1 &
                CboTipo_Movimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1 &
                CboTipo_Movimiento.SelectedIndex != -1)
            {
                VerMovimiento4();
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex != -1)
            {
                VerMovimiento();
            }
            else if (CboBanco.SelectedIndex != -1 & 
                CboTipo_Movimiento.SelectedIndex != -1)
            {
                VerMovimiento3();
            }
            else if (CboBanco.SelectedIndex != -1 &
                CboCuenta.SelectedIndex == -1)
            {
                VerMovimiento2();
            }
            else if (CboBanco.SelectedIndex == -1 &
                CboCuenta.SelectedIndex == -1)
            {
                VerMovimiento5();
            }
            else
            {
                MessageBox.Show("Seleccione un banco");
            }
        }

        private void BtnVer_Todos_Click(object sender, EventArgs e)
        {
            VisualizarMovimientos();

        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            BtnEliminar_Movimiento.Enabled = true;
        }


        private void BtnCancelar_Combo_Click(object sender, EventArgs e)
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

        private void BtnLimpiar_Tipo_Movimiento_Click(object sender, EventArgs e)
        {
            CboTipo_Movimiento.SelectedIndex = -1;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            DgvGestion_movimientos.DataSource = tabla;
        }
    }
}
