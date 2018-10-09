using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegistrarPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            String opcion;
            bool continuar = true;
            Personas p = new Personas();

            //Console.WriteLine("Seleccione una de las siguentes opciones");
            //Console.WriteLine("1 para registrar personas");
            //Console.WriteLine("2 para leer un archivo");
            //Console.WriteLine("3 para salir");
            //opcion = Console.ReadLine();
            while (continuar)
            {
                Console.WriteLine("Seleccione una de las siguentes opciones");
                Console.WriteLine("1 para registrar personas");
                Console.WriteLine("2 para leer un archivo");
                Console.WriteLine("3 para salir");
                opcion = Console.ReadLine();
                if (opcion == "1")
                {
                    p.RegistrarPersona();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == "2")
                {
                    p.LeerDirectorios();
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Adios");
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("El programa se cerrará debido a que no ingresaste opciones válidas");
                    continuar = false;
                }
            }
            //if(opcion == "1")
            //{
            //    p.RegistrarPersona();
            //}
            //else if (opcion == "2")
            //{
            //    p.LeerDirectorios();
            //}
            //else if (opcion == "3")
            //{
            //    Console.WriteLine("Adios");
            //}
            //else
            //{
            //    Console.WriteLine("El programa se cerrará debido a que no ingresaste opciones válidas");
            //}
            Console.ReadLine();
        }
    }
}