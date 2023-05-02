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
    public class CN_Movimiento
    {
        CD_Movimiento oCD_Movimiento= new CD_Movimiento();

        public void InsertarMovimiento(CE_Movimiento movimiento)
        {
            oCD_Movimiento.InsertarMovimiento(movimiento);
        }

        public void EliminarMovimiento(CE_Movimiento movimiento)
        {
            oCD_Movimiento.EliminarMovimiento(movimiento);
        }

        public DataTable VerMovimientos(CE_Cuenta cuenta)
        {
            DataTable tabla = oCD_Movimiento.VerMovimientos(cuenta);
            return tabla;
        }

        public DataTable VerMovimientos2(CE_Banco banco)
        {
            DataTable tabla = oCD_Movimiento.VerMovimientos2(banco);
            return tabla;
        }

        public DataTable VerMovimientos3(CE_Tipo_Movimiento tpmmovimiento, CE_Banco banco)
        {
            DataTable tabla = oCD_Movimiento.VerMovimientos3(tpmmovimiento,banco);
            return tabla;
        }

        public DataTable VerMovimientos4(CE_Tipo_Movimiento tpmmovimiento, CE_Banco banco, CE_Cuenta cuenta)
        {
            DataTable tabla = oCD_Movimiento.VerMovimientos4(tpmmovimiento, banco, cuenta);
            return tabla;
        }

        public DataTable VerMovimientos5(CE_Tipo_Movimiento tpmmovimiento)
        {
            DataTable tabla = oCD_Movimiento.VerMovimientos5(tpmmovimiento);
            return tabla;
        }

        public DataTable VisualizarMovimientos()
        {
            DataTable tabla = oCD_Movimiento.VisualizarMovimiento();
            return tabla;
        }
    }
}
