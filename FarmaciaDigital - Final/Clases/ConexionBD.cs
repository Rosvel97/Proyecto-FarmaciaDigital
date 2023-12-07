using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Windows.Forms;

namespace FarmaciaDigital.Clases
{
    public class ConexionBD
    {
        private SqlConnection conn;

        public ConexionBD()
        {
            string Servidor = "localhost";
            string cadenaConexion = @"Server ="+ Servidor + ";DataBase= FarmaciaDigital; Integrated Security=True";
            conn = new SqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar" + "Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void CerrarConexion()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection ObtenerConexion()
        {
            return conn;
        }
    }
}
