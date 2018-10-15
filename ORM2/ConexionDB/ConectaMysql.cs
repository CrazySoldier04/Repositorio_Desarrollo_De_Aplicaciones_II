using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConexionDB
{
    public class ConectaMysql : Ibd
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter adaptador;
        
        public DataTable resultados;
        public static string Error;
        public static bool error;
        public static string valor;
        public string conexion;

        ///Metodo para conectar a DB de MySQL. 
        public bool ConectaDB(string conexion)
        {
            bool res = false;
            try
            {
                //if (con.State == ConnectionState.Closed)
                //{
                    con = new MySqlConnection(conexion);  //"Server=localhost;Database=sopTec;Uid=root;Pwd=Qwer1234");
                    con.Open();
                    res = true;
                //}
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al conectar " + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al conectar. " + general.Message;
            }
            return res;
        }

        ///Metodo para cerrar conexion a DB
        public bool DesconectaDB()
        {
            bool res = false;
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    res = true;
                }
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al desconectar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al desconectar. " + general.Message;
            }
            return res;
        }

        /// <summary>
        /// Metodo para Consulta con tres parametros
        /// </summary>
        /// <param name="tabla">Nombre de la tabla a consultar</param>
        /// <param name="campos">Cadena de Campos a filtar</param>
        /// <param name="valores">Cadena de valores a buscar</param>
        /// <returns></returns>
        public bool Consultar(string tabla, string campos, string valores)
        {
            bool res = false;
            try
            {
                com = new MySqlCommand("SELECT " + campos + " FROM " + tabla + " WHERE " + valores + "'", con);
                ConectaDB(conexion);
                com.Connection = this.con;
                com.ExecuteReader();
                res = true;
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Consultar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Consultar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return res;
        }

        /// <summary>
        /// Metodo para consultar y regresar un valor con un parametro de carga.
        /// </summary>
        /// <param name="cadena">Es la cadena que se epera para ejecutar</param>
        /// <returns>Regresa un Valor</returns>
        public string ConsultaUnValor(string cadena)
        {
            try
            {
                com = new MySqlCommand(cadena, con);
                ConectaDB(conexion);
                com.Connection = this.con;
                com.ExecuteNonQuery();
                valor = com.ExecuteScalar().ToString();
                
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Consultar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Consultar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return valor;
        }

        /// <summary>
        /// Metodo para llenar DataGridView con 2 parametros de carga
        /// </summary>
        /// <param name="tabla">Tabla donde se genera la consulta</param>
        /// <param name="campos">cadena de campos a filtrar</param>
        /// <returns>Regresa un DataTable</returns>
        public DataTable ConsultaDT(string conexion, string cadena)
        {
            try
            {
                com = new MySqlCommand(cadena, con);
                ConectaDB(conexion);
                com.Connection = this.con;
                resultados = new DataTable();
                adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(resultados);
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Consultar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Consultar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return resultados;
        }

        /// <summary>
        /// Consulta que para llenar DataGridView con 3 parametros de carga
        /// </summary>
        /// <param name="tabla">Tabla a afectar con la consuta</param>
        /// <param name="campos">Cadena de campos a filtrar</param>
        /// <param name="condicion">condicion que se cumplira para la consulta</param>
        /// <returns>Regres aun DataTable</returns>
        public DataTable ConsultaDT(string tabla, string campos, string condicion)
        {
            try
            {
                com = new MySqlCommand("SELECT " + campos + "FROM " + tabla + " WHERE " + condicion, con);
                ConectaDB(conexion);
                com.Connection = this.con;
                resultados = new DataTable();
                adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(resultados);
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Consultar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Consultar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return resultados;
        }

        /// <summary>
        /// Consulta para llenar DataGridView con cadena compkleta, se utiliza para consultas especificas.
        /// </summary>
        /// <param name="cadena">Cadena qu ese espera para la consulta</param>
        /// <returns>Regresa un DataTable</returns>
        public DataTable ConsultaDT(string cadena)
        {
            try
            {
                com = new MySqlCommand(cadena, con);
                ConectaDB(conexion);
                com.Connection = this.con;
                resultados = new DataTable();
                adaptador = new MySqlDataAdapter(com);
                adaptador.Fill(resultados);
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Consultar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Consultar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return resultados;
        }

        /// <summary>
        /// Metodo para insertar registros en la base de datos
        /// </summary>
        /// <param name="tabla">Nombre de la tabla a afectar</param>
        /// <param name="campos">Cadena de campos a afectar</param>
        /// <param name="valores">Cadena de valores que se insertaran en la tabla.</param>
        /// <returns>Regresa true si se ejecuta correctamente y false si no se ejecuta.</returns>
        public bool Insertar(string tabla, string campos, string valores)
        {
            bool res = false;
            try
            {
                com = new MySqlCommand("INSERT INTO " + tabla + " (" + campos + ") VALUES (" + valores + ");", con);
                ConectaDB(conexion);
                com.Connection = this.con;
                com.ExecuteNonQuery();
                res = true;
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Insertar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Insertar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return res;
        }

        /// <summary>
        /// Metodo para actualizar tablas con un parametro de carga.
        /// </summary>
        /// <param name="cadena">adena comleta a ejecutar</param>
        /// <returns>regresa true si se ejecuta correctamente y false si no es asi.</returns>
        public bool Actualizar(string cadena)
        {
            bool res = false;
            try
            {
                com = new MySqlCommand(cadena, con);
                ConectaDB(conexion);
                com.Connection = this.con;
                com.ExecuteNonQuery();
                res = true;
            }
            catch (MySqlException mse)
            {
                ConectaMysql.Error = "Error SQL al Actualizar" + mse.Message;
            }
            catch (Exception general)
            {
                ConectaMysql.Error = "Error general al Actualizar. " + general.Message;
            }
            finally
            {
                DesconectaDB();
            }
            return res;
        }   
    }
}

