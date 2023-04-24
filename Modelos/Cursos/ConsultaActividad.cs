//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework.Modelos.Cursos
{
    internal class ConsultaActividad : Conexion
    {

        /// <summary>
        /// Método que realiza uan consulta de los diferentes temas que existen en la base de datos.
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>Una tabla de temas existentes en la base de datos.</returns>
        public Boolean busquedaTemaComboBox(DataTable dt)
        {
            Boolean seHizo = true;

            string sql = " SELECT idTema, nombreTema from Temas;";

            SqlConnection con = Conexion.conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                data.Fill(dt);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            return seHizo;
        }

        public Boolean existeActividad(Actividad act, Tema tema)
        {
            Boolean existe = false;
            Boolean seHizo = false;
            string sql = "SELECT * FROM Actividad , Temas WHERE Actividad.idActividad = @idActividad AND Actividad.idTema = @idTema AND Actividad.idTema = Temas.idTema";
            SqlDataReader reader = null;
            SqlConnection conn = Conexion.conectar();

            try
            {
              
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idActividad", act.Id);
                cmd.Parameters.AddWithValue("@idTema", tema.Id);
                reader = cmd.ExecuteReader();
                existe = reader.HasRows;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }


            return existe;
        }

        /// <summary>
        /// Método que realiza una consulta de búsqueda según el id de la actividad y el tema.
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="tema"></param>
        /// <returns>todos los valores de la tabla actividad de la base de datos.</returns>
        public Boolean buscarActividad(Actividad actividad, Tema tema)
        {
            Boolean seHizo =  false;
            string sql = "SELECT * FROM Actividad, tema WHERE Actividad.idActividad = @idActividad AND Actividad.idTema = @idTema AND Actividad.idTema = Temas.idTema";
            SqlDataReader reader = null;
            SqlConnection conn = Conexion.conectar();


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idActividad", actividad.Id);
                cmd.Parameters.AddWithValue("@idTema", tema.Id);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    seHizo = true;
                    while (reader.Read())
                    {
                        actividad.Id = reader.GetInt32(0);
                        actividad.Nombre = reader.GetString(1);
                        actividad.Horas = reader.GetDouble(2);
                        actividad.Descripcion = reader.GetString(3);
                        tema.Id = reader.GetInt32(4);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }

            return seHizo;
        }

        /// <summary>
        /// Inserción de una actividad nueva.
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="tema"></param>
        /// <returns>Regresa como respuesta verdadero o falso si se pudo realizar la inserción</returns>
        public Boolean insertarActividad(Actividad actividad, Tema tema)
        {
            Boolean respuesta = false;

            String sql = "INSERT INTO Actividad (idActividad, nombreAct, horas, descripcion, idTema) VALUES (@idActividad, @nombreAct, @horas, @descripcion, @idTema)";

            SqlConnection conexionBD = Conexion.conectar();
            conexionBD.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexionBD);
                cmd.Parameters.AddWithValue("@idActividad", actividad.Id);
                cmd.Parameters.AddWithValue("@nombreAct", actividad.Nombre);
                cmd.Parameters.AddWithValue("@horas", actividad.Horas);
                cmd.Parameters.AddWithValue("@descripcion", actividad.Descripcion);
                cmd.Parameters.AddWithValue("@idTema", tema.Id);
                cmd.ExecuteNonQuery();
                respuesta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
                
            }

            return respuesta;

        }

        public Boolean actualizarActividad(Actividad actividad, Tema tema)
        {
            Boolean respuesta = false;

            String sql = "UPDATE Actividad SET nombreAct = @nombreAct, Horas = @Horas, descripcion = @descripcion, idTema = @idTema WHERE idActividad = @idActividad AND idTema = @idTema";

            SqlConnection conexionBD = Conexion.conectar();
            conexionBD.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexionBD);
                cmd.Parameters.AddWithValue("@nombreAct", actividad.Nombre);
                cmd.Parameters.AddWithValue("@Horas", actividad.Horas);
                cmd.Parameters.AddWithValue("@descripcion", actividad.Descripcion);
                cmd.Parameters.AddWithValue("@idTema", tema.Id);
                cmd.Parameters.AddWithValue("@idActividad", actividad.Id);
                cmd.ExecuteNonQuery();
                respuesta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();

            }

            return respuesta;

        }
        public Boolean eliminarActividad(Actividad actividad, Tema tema)
        {
            Boolean respuesta = false;

            String sql = "DELETE FROM Actividad WHERE Actividad.idActividad = @idActividad AND Actividad.idTema = @idTema";

            SqlConnection conexionBD = Conexion.conectar();
            conexionBD.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexionBD);
                cmd.Parameters.AddWithValue("@idActividad", actividad.Id);
                cmd.Parameters.AddWithValue("@idTema", tema.Id);
                cmd.ExecuteNonQuery();
                respuesta = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();

            }

            return respuesta;

        }




    }
}
