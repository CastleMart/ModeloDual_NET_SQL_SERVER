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
                //Leer la información para la conexión de la base de datos desde el archivo de configuración.
                String cadenaConexion = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                
                //Crear la conexión mandarla para su uso.
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
