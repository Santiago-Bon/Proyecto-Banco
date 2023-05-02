using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Movimiento
    {
        public int id { get; set; }

        public float monto { get; set; }

        public DateTime fecha { get; set; }

        public int id_tipo_movimiento { get; set; }

        public int id_cuenta { get; set; }

    }
}
