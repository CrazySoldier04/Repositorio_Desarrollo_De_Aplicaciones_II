using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDB;

namespace ConexionDB
{
    public class ExecuteQuery
    {
        public static string MsgServidor;
        public static bool CreaTablaMysql(string query) {
            Ibd bd = new ConectaMysql();
            bool res = bd.ExecutaQueryTabla(query);
            if (res)
            {
                MsgServidor = "Mysql: Tabla creada..";
                Tabla.State = FlagState.CREADA;
                return true;
            }
            else
            {
                MsgServidor = "Mysql: Error_syntaxis...";
                Tabla.State = FlagState.ERROR_SYNTAXIS;
                return false;
            }
        }
        public static bool InsertIntoMysql(string Query) {
            Ibd bd = new ConectaMysql();
            bool res = bd.ExecutaQueryTabla(Query);
            if (res)
            {
                Tabla.State = FlagState.INSERTADO;
                return true;
            }
            else
            {
                Tabla.State = FlagState.ERROR_SYNTAXIS;
                return false;
            }
        }
    }
}
