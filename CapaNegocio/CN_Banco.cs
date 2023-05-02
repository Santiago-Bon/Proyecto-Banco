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
    public class CN_Banco
    {
        CD_Banco oCD_Banco = new CD_Banco();

        public DataTable BuscarBanco()
        {
            DataTable tabla = oCD_Banco.BuscarBanco();
            return tabla;
        }

        public bool BuscarBancos(CE_Banco banco)
        {
            DataTable encontrado = oCD_Banco.BuscarBancos(banco);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }

        public bool BuscarBancosEditar(CE_Banco banco)
        {
            DataTable encontrado = oCD_Banco.BuscarBancosEditar(banco);
            if (encontrado.Rows.Count > 0)
            {
                return true;
            }

            else
                return false;
        }


        public void InsertarBanco(CE_Banco banco)
        {
            oCD_Banco.InsertarBanco(banco);
        }

        public void EditarBanco(CE_Banco banco)
        {
            oCD_Banco.EditarBanco(banco);
        }

        public void EliminarBanco(CE_Banco banco)
        {
            oCD_Banco.EliminarBanco(banco);
        }
    }
}
