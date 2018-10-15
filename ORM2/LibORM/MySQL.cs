using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDB;
using System.Data;

namespace LibORM
{
    public class MySQL
    {
        ConectaMysql con = new ConectaMysql();
        bool res;

        public bool Conexion(string cadena)
        {
            res = false;
            if (con.ConectaDB(cadena))
            {
                res = true;
            }
            return res;
        }

        public DataTable ConsultaDT(string cadena, string Query )
        {
            return con.ConsultaDT(cadena, Query);
        }
    }
}
