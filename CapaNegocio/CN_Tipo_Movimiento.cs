using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Tipo_Movimiento
    {
        CD_Tipo_Movimiento oCD_Tipo_Movimiento = new CD_Tipo_Movimiento();




        public DataTable BuscarTipo_Movimiento()
        {
            DataTable tabla = oCD_Tipo_Movimiento.BuscarTipo_Movimiento();
            return tabla;
        }
    }
}
