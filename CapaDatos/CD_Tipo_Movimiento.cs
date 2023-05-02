using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Tipo_Movimiento
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();



        public DataTable BuscarTipo_Movimiento()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarTipo_Movimiento";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
