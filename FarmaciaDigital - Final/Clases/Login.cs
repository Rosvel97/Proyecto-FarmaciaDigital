using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaDigital.Clases
{
    public class Login: ConexionBD
    {

        public bool Log_in(string User, string Password)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SP_Inicio_Sesion";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Usuario", User);
                    comando.Parameters.AddWithValue("@Pass", Password);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            LoginEntidades.User = reader.GetString(0);
                            LoginEntidades.Nombre = reader.GetString(1);
                            LoginEntidades.Apellido = reader.GetString(2);
                            LoginEntidades.Rol = reader.GetString(3);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
