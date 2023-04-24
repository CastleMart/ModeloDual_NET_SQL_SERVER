using ModeloDual_NET_Framework.Modelos.Cursos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    internal class Conexion
    {
        private String mensaje;
        public static MySqlConnection conectar()
        {
                    

            try
            {
                var cadenaConexion = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                return conexion;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
