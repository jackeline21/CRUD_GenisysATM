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
    class CuentaCliente
    {
        // Propiedades de la clase
        public string numero { get; set; }
        public int idCliente { get; set; }
        public decimal saldo { get; set; }
        public string pin { get; set; }

        public string nuevoNumero { get; set; }

        // Constructor
        public CuentaCliente() { }

        
        public static CuentaCliente ObtenerCliente(string cuenta)
        {
            
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = new CuentaCliente();
            string sql = @"SELECT *
                           FROM ATM.CuentaCliente
                           WHERE numero = @cuenta";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cuenta", SqlDbType.Char, 14).Value = cuenta;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    laCuenta.numero = rdr.GetString(0);
                    laCuenta.idCliente = rdr.GetInt32(1);
                    laCuenta.saldo = rdr.GetDecimal(2);
                    laCuenta.pin = rdr.GetString(3);
                    //removemos espacios en blanco de la cuenta del numero
                    laCuenta.numero = laCuenta.numero.TrimEnd();
                }

                return laCuenta;
            }
            catch (SqlException )
            {
                return laCuenta;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

       
        public static bool ActualizarSaldo(string cuenta, decimal debito)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = CuentaCliente.ObtenerCliente(cuenta);

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarSaldoCuenta");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("debito", SqlDbType.Decimal));
            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["debito"].Value = debito;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException )
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public static bool ActualizarPin(CuentaCliente laCuenta, string pinNuevo)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarPin");
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("pinActual", SqlDbType.Char, 4));
            cmd.Parameters.Add(new SqlParameter("pinNuevo", SqlDbType.Char, 4));

            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["pinActual"].Value = laCuenta.pin;
            cmd.Parameters["pinNuevo"].Value = pinNuevo;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException )
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

       
        public static List<CuentaCliente> LeerTodasCuentas(string Nombre)
        {
            // Lista una de tipo de clientes
            List<CuentaCliente> resultados = new List<CuentaCliente>();

            //instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            string sql = @"DECLARE @codigoCliente INT
                  SET @codigoCliente =(SELECT id FROM ATM.Cliente WHERE nombres=@Cliente);
                  SELECT * FROM ATM.CuentaCliente WHERE idCliente=@codigoCliente;
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
                // Ejecutar el query via un ExecuteReader



                //Recorremos los elementos que se encuentra guardados
                // en la lista tipo cliente
                while (rdr.Read())
                {
                    CuentaCliente cuenta = new CuentaCliente();
                    // Asignar los valores de Reader al objeto Departamento
                    cuenta.numero = rdr.GetString(0);
                    cuenta.idCliente = rdr.GetInt32(1);
                    cuenta.saldo = rdr.GetDecimal(2);
                    cuenta.pin = rdr.GetString(3);
                    // Agregar el servicio a la List<servicio>
                    resultados.Add(cuenta);
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


        public static bool InsertarCuenta(CuentaCliente laCuenta, string cliente)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            // enviamos y especificamos el comando a ejecutar
            SqlCommand cmd = conn.EjecutarComando("sp_InsertarCuenta");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = cliente;

            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = laCuenta.saldo;

            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.Char, 4));
            cmd.Parameters["@pin"].Value = laCuenta.pin;

            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;

            // intentamos insertar la nueva cuenta
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

        public static bool ActualizarCuenta(CuentaCliente laCuenta, string cliente)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            
            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarCuentaCliente");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros 

            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = cliente;

            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = laCuenta.saldo;

            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.Char, 4));
            cmd.Parameters["@pin"].Value = laCuenta.pin;

            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;

            cmd.Parameters.Add(new SqlParameter("@nuevoNumero", SqlDbType.Char, 14));
            cmd.Parameters["@nuevoNumero"].Value = laCuenta.nuevoNumero;

            // Probar actualizar
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


        public static bool EliminarCuenta(CuentaCliente laCuenta)
        {

            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

          
            SqlCommand cmd = conn.EjecutarComando("sp_EliminarCuenta");
            cmd.CommandType = CommandType.StoredProcedure;

            // agregamos los parámetros que son requeridos

            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;

            // Probar Eliminar la nueva cuenta
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
