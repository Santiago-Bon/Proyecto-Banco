using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Cuenta
    {
        public string numero_cuenta { get; set; }

        public string nombre { get; set; }

        public float saldo { get; set; }

        public int id_banco { get; set; }

        public int id_tipo_cuenta { get; set; }
    }
}

