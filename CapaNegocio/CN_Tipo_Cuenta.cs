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
    public class CN_Tipo_Cuenta
    {
        CD_Tipo_Cuenta oCD_Tipo_Cuenta = new CD_Tipo_Cuenta();


        public DataTable BuscarTipo_Cuenta()
        {
            DataTable tabla = oCD_Tipo_Cuenta.BuscarTipo_Cuenta();
            return tabla;
        }

        public bool BuscarTipoCuenta(CE_Tipo_Cuenta registro)
        {
            DataTable encontrado = oCD_Tipo_Cuenta.BuscarTipoCuenta(registro);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public bool BuscarTipoCuentaEditar(CE_Tipo_Cuenta registro)
        {
            DataTable encontrado = oCD_Tipo_Cuenta.BuscarTipoCuentaEditar(registro);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public void InsertarTipoCuenta(CE_Tipo_Cuenta tipo_cuenta)
        {
            oCD_Tipo_Cuenta.InsertarTipoCuenta(tipo_cuenta);
        }

        public void EditarTipoCuenta(CE_Tipo_Cuenta tipo_cuenta)
        {
            oCD_Tipo_Cuenta.EditarTipoCuenta(tipo_cuenta);
        }
        public void EliminarTipoCuenta(CE_Tipo_Cuenta tipo_cuenta)
        {
            oCD_Tipo_Cuenta.EliminarTipoCuenta(tipo_cuenta);
        }
    }
}
