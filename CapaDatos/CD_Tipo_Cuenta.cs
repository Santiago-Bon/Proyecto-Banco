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
    public class CD_Tipo_Cuenta
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();



        public DataTable BuscarTipo_Cuenta()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarTipo_Cuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarTipoCuenta(CE_Tipo_Cuenta registro)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarTipoCuenta";
            Comando.Parameters.AddWithValue("@nombre", registro.nombre_tipo_cuenta);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarTipoCuentaEditar(CE_Tipo_Cuenta registro)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarTipoCuentaEditar";
            Comando.Parameters.AddWithValue("@id", registro.id);
            Comando.Parameters.AddWithValue("@nombre", registro.nombre_tipo_cuenta);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }


        public void InsertarTipoCuenta(CE_Tipo_Cuenta tipo_Cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InsertarTipoCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@nombre", tipo_Cuenta.nombre_tipo_cuenta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarTipoCuenta(CE_Tipo_Cuenta tipo_Cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EditarTipoCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", tipo_Cuenta.id);
            Comando.Parameters.AddWithValue("@nombre", tipo_Cuenta.nombre_tipo_cuenta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarTipoCuenta(CE_Tipo_Cuenta tipo_Cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EliminarTipoCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@id", tipo_Cuenta.id);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
