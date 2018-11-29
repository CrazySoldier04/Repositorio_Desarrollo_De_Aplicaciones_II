using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConexionDB
{
    public class Hilo
    {
        public static string Msg3;
        public static string Msg2;
        public static string Msg;
        private static string cadena;
        private static Thread threadCreateSql = new Thread(new ThreadStart(EjecutaCreateSql));
        private static Thread threadCreateMysql = new Thread(new ThreadStart(EjecutaCreateMysql));
        private static Thread threadInsertSql = new Thread(new ThreadStart(EjecutaInsertSql));
        private static Thread threadInsertMysql = new Thread(new ThreadStart(EjecutaInsertMysql));

        private static void EjecutaCreateSql() {
            ConectaSQL sql = new ConectaSQL();
            Thread.Sleep(1000);
            //Msg2 = ("ThreadState:" + threadCreateSql.ThreadState);

            if (sql.ExecutaQueryTabla(cadena)){ Msg3 = "True";}
            else { Msg3 = "False"; }

            //Msg3 = ("ThreadState:" + threadCreateSql.ThreadState);
        }
        private static void EjecutaCreateMysql(){
            ConectaMysql mysql = new ConectaMysql();
            Thread.Sleep(1000);
            Msg2 = ("ThreadState:" + threadCreateMysql.ThreadState);
            
            if (mysql.ExecutaQueryTabla(cadena)) { Msg = "Tabla Creada Correctamente"; }
            else { Msg = ConectaMysql.Error; }
            //Msg3 = ("ThreadState:" + threadCreateSql.ThreadState);
        }
        private static void EjecutaInsertMysql()
        {
            ConectaMysql mysql = new ConectaMysql();
            if (mysql.ExecutaQueryInsert(cadena)) { Msg = "True"; }
            else { Msg = "False"; }
        }
        private static void EjecutaInsertSql()
        {
            ConectaSQL sql = new ConectaSQL();
            if (sql.ExecutaQueryInsert(cadena)) { Msg = "True"; }
            else { Msg = "False"; }
        }
        public static void EjecutaCreateHilos(string sentencia) {
            cadena = sentencia;
            //threadCreateSql.Start();
            if (threadCreateMysql.IsAlive)
            {
                //threadCreateMysql.ThreadState = ThreadState.AbortRequested;
            }
            threadCreateMysql.Start();
            threadCreateMysql.Join();
            //threadCreateSql.Join();
        }
        public static void EjecutaInsertHilo(string sentencia) {
            cadena = sentencia;
            threadInsertSql.Start();
            threadInsertMysql.Start();
            threadInsertMysql.Join();
            threadInsertSql.Join();
        }
    }
}