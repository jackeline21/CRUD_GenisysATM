using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_GenisysATM.Models
{
    class ServicioPublico
    {
        // Propiedades
        public int id { get; set; }
        public string descripcion { get; set; }
        public string descripcionactual { get; set; }

        // Constructores
        public ServicioPublico() { }


        public static ServicioPublico obtenerServicio(string descripcion)
        {
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql;
            ServicioPublico resultado = new ServicioPublico();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.ServicioPublico
                    WHERE descripcion = @descripcion";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = descripcion;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt32(0);
                    resultado.descripcion = rdr.GetString(1);
                }

                return resultado;
            }
            catch (SqlException)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public static List<ServicioPublico> LeerTodos()
        {
            // Lista una de tipo  servicioPublico
            List<ServicioPublico> resultados = new List<ServicioPublico>();

            //instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql = @"SELECT *
                    FROM ATM.ServicioPublico";

            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecer la conexión
                conexion.EstablecerConexion();

                // Ejecutar el query via un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

             
                while (rdr.Read())
                {
                    ServicioPublico servi = new ServicioPublico();
                    // Asignar los valores de Reader al objeto Departamento
                    servi.id = rdr.GetInt32(0);
                    servi.descripcion = rdr.GetString(1);

                    // Agregar el Departamento a la List<Departamento>
                    resultados.Add(servi);
                }

                return resultados;
            }
            catch (SqlException)
            {
                return resultados;
            }
            finally
            {
                // Cerrar la conexión
                conexion.CerrarConexion();
            }
        }

        public static bool InsertarServicio(ServicioPublico elServicio)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_InsertarServicio");
            cmd.CommandType = CommandType.StoredProcedure;
            

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcion;

        
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        
        public static bool ActualizarServicio(ServicioPublico elServicio)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarServicio");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcionactual;

            cmd.Parameters.Add(new SqlParameter("@descripcionNueva", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcionNueva"].Value = elServicio.descripcion;

          
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

     
        public static bool EliminarServicio(ServicioPublico elServicio)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_EliminarServicio");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcion;

            
            try
            {
                // establecemos la conexión
                conn.EstablecerConexion();

                // ejecutamos el comando
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Detalles de la excepción");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
