using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibBaseDatosORM
{
    public class MySql
    {
        public String errorMsge;
        private bool res = false;
        MySqlConnection cn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;

        /// <summary>
        ///Con este método se realiza una conexión al servidor de MySql con los parámetros por default.
        /// </summary>
        public MySql()
        {
            cn = new MySqlConnection("host=localhost;uid=root;pwd=salazar;database=information_schema;");
        }

        /// <summary>
        /// Con este método se realiza una conexión con parámetros específicos para el servidor de MySql.
        /// </summary>
        /// <param name="host">Nombre de host o dirección donde está el servidor.</param>
        /// <param name="user">Usuario del servidor.</param>
        /// <param name="pwd">Contraseña de usuario.</param>
        /// <param name="port">Puerto específico para conectarse al servidor.</param>
        /// <param name="database">nombre de la base de datos a conectarse.</param>
        public MySql(String host, String user, String pwd, String port, String database)
        {
            cn = new MySqlConnection("host=" + host + ";uid=" + user + ";pwd=" + pwd + ";database=" + database + ";port=" + port + ";");
        }

        public bool OpenConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    res = true;
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error al abrir la conexión: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general: " + ex.ToString();
            }
            return res;
        }

        public bool CloseConnection()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                    res = true;
                }
            }
            catch (MySqlException mysqlex)
            {
                errorMsge = "Error al cerrar la conexión: " + mysqlex.ToString();
            }
            catch (Exception ex)
            {
                errorMsge = "Error general: " + ex.ToString();
            }
            return res;
        }
    }
}
