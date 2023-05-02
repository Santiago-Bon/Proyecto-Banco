using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cuenta
    {
        CD_Cuenta oCD_Cuenta = new CD_Cuenta();


        public DataTable BuscarCuenta(int idbanco)
        {
            DataTable tabla = oCD_Cuenta.BuscarCuenta(idbanco);
            return tabla;
        }


        public DataTable VerCuenta(CE_Cuenta cuenta)
        {
            DataTable tabla = oCD_Cuenta.VerCuenta(cuenta);
            return tabla;
        }

        public DataTable VerCuenta2(CE_Banco banco)
        {
            DataTable tabla = oCD_Cuenta.VerCuenta2(banco);
            return tabla;
        }

        public DataTable VerCuenta3(CE_Banco banco,CE_Tipo_Cuenta tpcCuenta)
        {
            DataTable tabla = oCD_Cuenta.VerCuenta3(banco,tpcCuenta);
            return tabla;
        }

        public DataTable VerCuenta4(CE_Banco banco, CE_Tipo_Cuenta tpcCuenta, CE_Cuenta cuenta)
        {
            DataTable tabla = oCD_Cuenta.VerCuenta4(banco, tpcCuenta, cuenta);
            return tabla;
        }

        public DataTable VerCuenta5(CE_Tipo_Cuenta tpcCuenta)
        {
            DataTable tabla = oCD_Cuenta.VerCuenta5(tpcCuenta);
            return tabla;
        }

        public DataTable MostrarCuenta()
        {
            DataTable tabla = oCD_Cuenta.MostrarCuenta();
            return tabla;
        }



        public DataTable VisualizarCuenta()
        {
            DataTable tabla = oCD_Cuenta.VisualizarCuenta();
            return tabla;
        }


        //public string TraerSaldo(CE_Cuenta saldo)
        //{
        //    string nsaldo = oCD_Cuenta.TraerSaldo(saldo);
        //    return nsaldo;
        //}


        public bool BuscarNumeroCuenta(CE_Cuenta numero)
        {
            DataTable encontrado = oCD_Cuenta.BuscarNumeroCuenta(numero);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public bool BuscarNumeroCuentaEditar(CE_Cuenta numero)
        {
            DataTable encontrado = oCD_Cuenta.BuscarNumeroCuentaEditar(numero);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public void InsertarCuenta(CE_Cuenta cuenta)
        {
            oCD_Cuenta.InsertarCuenta(cuenta);
        }


        public void EditarCuenta(CE_Cuenta cuenta)
        {
            oCD_Cuenta.EditarCuenta(cuenta);
        }

        public void EliminarCuenta(CE_Cuenta cuenta)
        {
            oCD_Cuenta.EliminarCuenta(cuenta);
        }

        public void ActualizarSaldo(CE_Cuenta cuenta)
        {
            oCD_Cuenta.ActualizarSaldo(cuenta);
        }
    }
}
