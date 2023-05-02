using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_Banco
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();


        public DataTable BuscarBanco()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarBancos(CE_Banco banco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarBancos";
            Comando.Parameters.AddWithValue("@nombre", banco.nombre_banco);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarBancosEditar(CE_Banco banco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarBancosEditar";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@nombre", banco.nombre_banco);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }


        public void InsertarBanco(CE_Banco banco)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InsertarBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@nombre", banco.nombre_banco);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarBanco(CE_Banco banco)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EditarBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@nombre", banco.nombre_banco);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarBanco(CE_Banco banco)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EliminarBanco";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
