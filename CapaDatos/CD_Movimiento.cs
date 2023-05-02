using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Movimiento
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();




        public void InsertarMovimiento(CE_Movimiento movimiento)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InsertarMovimiento";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@fecha", movimiento.fecha);
            Comando.Parameters.AddWithValue("@monto", movimiento.monto);
            Comando.Parameters.AddWithValue("@id_cuenta", movimiento.id_cuenta);
            Comando.Parameters.AddWithValue("@id_tipo_movimiento", movimiento.id_tipo_movimiento);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarMovimiento(CE_Movimiento movimiento)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EliminarMovimiento";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", movimiento.id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public DataTable VerMovimientos(CE_Cuenta cuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VerMovimientos";
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerMovimientos2(CE_Banco banco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VerMovimientos2";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerMovimientos3(CE_Tipo_Movimiento tpmMovimiento, CE_Banco banco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VerMovimientos3";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@tpmid", tpmMovimiento.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerMovimientos4(CE_Tipo_Movimiento tpmMovimiento, CE_Banco banco, CE_Cuenta cuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VerMovimientos4";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@tpmid", tpmMovimiento.id);
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerMovimientos5(CE_Tipo_Movimiento tpmMovimiento)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VerMovimientos5";
            Comando.Parameters.AddWithValue("@tpmid", tpmMovimiento.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VisualizarMovimiento()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VisualizarMovimientos";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }
    }
}
