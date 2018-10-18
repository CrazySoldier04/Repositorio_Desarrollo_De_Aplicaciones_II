using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBase_Datos;

namespace ORM_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuarios users = new Usuarios();
            users.Name = "Eliott";
            users.Apellido = "Salazar";
            users.Correo = "eliottsalazar@gmail.com";
            users.Telefono = "6622814620";
            users.Rfc = "kjdaiosdhiash23";
            string format = users.Telefono + "Incorrecto";
            Console.ReadKey();
        }
    }
}