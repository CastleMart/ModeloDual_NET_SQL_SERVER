using ModeloDual_NET_Framework.Modelos.Cursos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    internal class Conexion
    {
        private String mensaje;
        public static SqlConnection conectar()
        {
                    

            try
            {
                //var cadenaConexion = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                //MySqlConnection conexion = new MySqlConnection(cadenaConexion);

                /*var builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"DESKTOP-M164FR2\SQLEXPRESS";
                builder.InitialCatalog = "ModeloDual";
                builder.IntegratedSecurity = true;*/

                //var conexion = builder.ToString();
                var cadenaConexion = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                

                return conexion;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
