using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Proyecto_Banco : Form
    {
        CN_Conexion conexion = new CN_Conexion();
        public Proyecto_Banco()
        {
            InitializeComponent();
        }

        private void Proyecto_Banco_Load(object sender, EventArgs e)
        {
            Form Realizar_Movimiento = new Realizar_Movimiento();
            Abrir(Realizar_Movimiento);
        }

        #region Mis métodos

        private void Abrir(Form hijo) 
        {
            this.panel1.Controls.Clear(); 
            hijo.TopLevel = false; 
            hijo.Dock = DockStyle.Fill; 
            this.panel1.Controls.Add(hijo); 
            hijo.Show(); 
        }


        #endregion

        private void verMisCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ver_Mis_Cuentas = new Ver_Cuentas();
            Abrir(Ver_Mis_Cuentas);
        }

        private void gestiónDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestion_cuentas = new Cuenta();
            Abrir(gestion_cuentas);
        }

        private void gestiónDeTipoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestion_tipo_cuenta = new Tipo_Cuenta();
            Abrir(gestion_tipo_cuenta);
        }

        private void realizarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Realizar_Movimiento = new Realizar_Movimiento();
            Abrir(Realizar_Movimiento);
        }

        private void verMisMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ver_movimientos = new Ver_Movimientos();
            Abrir(ver_movimientos);
        }

        private void gestiónDeBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestion_bancos = new Bancos();
            Abrir(gestion_bancos);
        }

        private void gestiónDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form gestion_movimientos= new Gestion_Movimientos();
            Abrir(gestion_movimientos);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void generarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string comando_consulta;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo txt (*.bak)|*.bak";
            sfd.Title = "Guardar";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                comando_consulta = "BACKUP DATABASE [" + conexion.ConexionAbrir().Database + "] TO  DISK = N'" + sfd.FileName + "'";
                try
                {
                    conexion.ConexionAbrir();
                    SqlCommand cmd = new SqlCommand(comando_consulta, conexion.ConexionAbrir());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La copia se ha creado satisfactoriamente");
                    conexion.ConexionCerrar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            sfd.Dispose();
        }

        private void restaurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Restaurar";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string database = conexion.ConexionAbrir().Database.ToString();
                conexion.ConexionAbrir();
                try
                {
                    string stri = "ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE"; //alterar la base de datos [" + base de datos + "] establecer usuario único con reversión inmediata
                    SqlCommand comando = new SqlCommand(stri, conexion.ConexionAbrir());
                    comando.ExecuteNonQuery();

                    string stri2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK ='" + dlg.FileName + "' WITH REPLACE;"; //use la base de datos de restauración maestra [" + base de datos + "] desde el disco = '" + txt_restaura.Text + "' con reemplazar
                    SqlCommand comando2 = new SqlCommand(stri2, conexion.ConexionAbrir());
                    comando2.ExecuteNonQuery();

                    string stri3 = "ALTER DATABASE [" + database + "] SET MULTI_USER"; //modificar base de datos[" + base de datos + "] establecer multiusuario
                    SqlCommand comando3 = new SqlCommand(stri3, conexion.ConexionAbrir());
                    comando3.ExecuteNonQuery();

                    MessageBox.Show("Restauracion Completa");
                    conexion.ConexionCerrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
