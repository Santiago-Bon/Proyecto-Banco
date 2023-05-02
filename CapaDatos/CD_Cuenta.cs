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
    public class CD_Cuenta
    {
        CD_Conexion conexion = new CD_Conexion();

        SqlDataReader Leer;
        SqlCommand Comando = new SqlCommand();
        DataTable Tabla = new DataTable();



        public DataTable BuscarCuenta(int idbanco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Buscarcuenta";
            Comando.Parameters.AddWithValue("@id_banco", idbanco);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }



        public DataTable MostrarCuenta()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Mostrarcuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }


        public DataTable VisualizarCuenta()
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "VisualizarCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }



        //public string TraerSaldo(CE_Cuenta saldo)
        //{
        //    //SqlCommand comando2 = new SqlCommand();
        //    //SqlDataReader Leer2;
        //    Comando.Parameters.Clear();
        //    Comando.Connection = conexion.AbrirConexion();
        //    Comando.CommandText = "TraerSaldo";
        //    Comando.Parameters.AddWithValue("@numero", saldo.numero_cuenta);
        //    Comando.CommandType = CommandType.StoredProcedure;
        //    Leer = Comando.ExecuteReader();
        //    if (Leer.Read())
        //    {
        //        string nsaldo = Leer["saldo"].ToString();
        //        Leer.Close();
        //        return nsaldo;

        //    }
        //    else
        //    {
        //        Leer.Close();
        //        return " ";
        //    }
        //    conexion.CerrarConexion();
        //}


        public DataTable BuscarNumeroCuenta(CE_Cuenta numero)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarNumerocuenta";
            Comando.Parameters.AddWithValue("@numero", numero.numero_cuenta);
            Comando.Parameters.AddWithValue("@id_banco", numero.id_banco);
            Comando.Parameters.AddWithValue("@nombre", numero.nombre);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable BuscarNumeroCuentaEditar(CE_Cuenta numero)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "BuscarNumerocuentaEditar";
            Comando.Parameters.AddWithValue("@numero", numero.numero_cuenta);
            Comando.Parameters.AddWithValue("@nombre", numero.nombre);
            Comando.Parameters.AddWithValue("@id_banco", numero.id_banco);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }


        public DataTable VerCuenta(CE_Cuenta cuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Vercuenta";
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerCuenta2(CE_Banco banco)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Vercuenta2";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerCuenta3(CE_Banco banco, CE_Tipo_Cuenta tpcCuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Vercuenta3";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@tpcid", tpcCuenta.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerCuenta4(CE_Banco banco, CE_Tipo_Cuenta tpcCuenta, CE_Cuenta cuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Vercuenta4";
            Comando.Parameters.AddWithValue("@id", banco.id);
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.Parameters.AddWithValue("@tpcid", tpcCuenta.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public DataTable VerCuenta5(CE_Tipo_Cuenta tpcCuenta)
        {
            DataTable Tabla = new DataTable();
            Comando.Parameters.Clear();
            Tabla.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Vercuenta5";
            Comando.Parameters.AddWithValue("@tpcid", tpcCuenta.id);
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            Comando.Parameters.Clear();
            Tabla.Load(Leer);
            conexion.CerrarConexion();
            return Tabla;
        }

        public void InsertarCuenta(CE_Cuenta cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "InsertarCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.Parameters.AddWithValue("@nombre", cuenta.nombre);
            Comando.Parameters.AddWithValue("@saldo", cuenta.saldo);
            Comando.Parameters.AddWithValue("@id_banco", cuenta.id_banco);
            Comando.Parameters.AddWithValue("@id_tipo_cuenta", cuenta.id_tipo_cuenta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EditarCuenta(CE_Cuenta cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EditarCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.Parameters.AddWithValue("@nombre", cuenta.nombre);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void EliminarCuenta(CE_Cuenta cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "EliminarCuenta";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


        public void ActualizarSaldo(CE_Cuenta cuenta)
        {
            Comando.Parameters.Clear();
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "ActualizarSaldo";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@numero", cuenta.numero_cuenta);
            Comando.Parameters.AddWithValue("@saldo", cuenta.saldo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
