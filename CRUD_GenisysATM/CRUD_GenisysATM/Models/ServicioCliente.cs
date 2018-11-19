﻿using System;
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
    class ServicioCliente
    {
        // Propiedades de la clase
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idServicio { get; set; }
        public decimal saldo { get; set; }

        public string detalle { get; set; }
        // Constructores
        public ServicioCliente() { }

  
        public static List<Cliente> LeerTodosClientes()
        {
            // Llamar al método
            List<Cliente> listar = new List<Cliente>();
            listar = Cliente.LeerTodos();
            return listar;
        }

        public static List<ServicioPublico> LeerTodosServicios()
        {
            //llamamos al método listar de la clase clientes.
            List<ServicioPublico> listar = new List<ServicioPublico>();
            listar = ServicioPublico.LeerTodos();
            return listar;
        }


        public static List<ServicioCliente> LeerTodosServiciosCliente (string Nombre)
        {
            // Lista una de tipo de clientes
            List<ServicioCliente> resultados = new List<ServicioCliente>();

            //instanciar la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql = @"DECLARE @codigoCliente INT
                  SET @codigoCliente =(SELECT id FROM ATM.Cliente WHERE nombres=@Cliente);
                  SELECT sp.descripcion,sc.saldo FROM ATM.ServicioPublico AS sp INNER JOIN ATM.ServicioCliente AS sc ON sc.idServicio=sp.id and sc.idCliente=@codigoCliente;
                  ";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            
            
            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@Cliente", SqlDbType.NVarChar, 100).Value = Nombre;
                }
                // Establecer la conexión
                conexion.EstablecerConexion();

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ServicioCliente cli = new ServicioCliente();
                    cli.detalle = rdr.GetString(0);
                    cli.saldo = rdr.GetDecimal(1);
                    // Agregar el servicio a la List<servicio>
                    resultados.Add(cli);
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


        public static ServicioCliente LeerDatoServicio(string servicio, string cliente)
        {
            // Lista una de tipo de clientes
            ServicioCliente resultados = new ServicioCliente();

            //instanciar la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql = @"DECLARE @codigoServicio INT
                           DECLARE @codigoCliente INT
				           SET @codigoCliente =(SELECT id FROM ATM.Cliente WHERE nombres=@Nombre);
                           SET @codigoServicio =(SELECT id FROM ATM.ServicioPublico WHERE descripcion=@Servicio);
                  SELECT sc.id,sc.saldo FROM  ATM.ServicioCliente AS sc WHERE sc.idServicio=@codigoServicio and idCliente=@codigoCliente ;";

            SqlCommand cmd = conexion.EjecutarComando(sql);


            try
            {

                using (cmd)
                {
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = cliente;
                    cmd.Parameters.Add("@Servicio", SqlDbType.NVarChar, 100).Value = servicio;
                }
                // Establecer la conexión
                conexion.EstablecerConexion();

                SqlDataReader rdr = cmd.ExecuteReader();
                // Ejecutar el query 

                while (rdr.Read())
                {
                   
                    // Asignar los valores de Reader al objeto Departamento
                    resultados.id = rdr.GetInt32(0);
                   resultados.saldo = rdr.GetDecimal(1);
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


        public static bool InsertarClienteServicio(string elCliente, string elServicio, ServicioCliente sc)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_InsertarServicioCliente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;

            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value =elServicio;

            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = sc.saldo;

            // intentamos insertar al nuevo cliente
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

        public static bool ActualizarClienteServicio(string elCliente, string elServicio, ServicioCliente sc)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarServicioCliente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;

            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value = elServicio;

            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = sc.saldo;

            // intentamos insertar al nuevo cliente
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

        public static bool EliminarClienteServicio(string elCliente, string elServicio)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_EliminarServicioCliente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;

            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value = elServicio;

            // intentamos insertar al nuevo cliente
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
