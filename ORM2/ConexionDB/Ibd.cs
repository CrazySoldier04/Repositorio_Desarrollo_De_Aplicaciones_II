using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConexionDB
{
    public interface Ibd
    {
        /// <summary>
        /// Abre una conexion ya definida de base de datos.
        /// </summary>
        /// <returns>true cuandose abre correctamente, false cuando hay error</returns>
        bool ConectaDB(string cadena);

        /// <summary>
        /// Cierra laconexion a base de datos ya abierta
        /// </summary>
        /// <returns>regresa tru cuando se cierra y false cuando hay errores</returns>
        bool DesconectaDB();

        /// <summary>
        /// Creara un registro nuevo.
        /// </summary>
        /// <param name="tabla">La tabladonde se inserta</param>
        /// <param name="campos">Campos separados por comas</param>
        /// <param name="valores">valores a iinsertar con apostrolfes y separadosporcomas</param>
        /// <returns>regresa true en operadcioon correcta y false si hay error.</returns>
        bool Insertar(string tabla, string campos, string valores);
        bool Actualizar(string tabla);
        DataTable ConsultaDT(string tabla);
        //object consultaUnValor(string tabla, string campo, string where);
        string ConsultaUnValor(string cadena);
        bool Consultar(string tabla, string campos, string valores);
    }
}
