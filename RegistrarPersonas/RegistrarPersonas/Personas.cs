using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RegistrarPersonas
{
    class Personas
    {
        String nombre, apellidos, curp, rfc, cel, correo, directorio;

        public void RegistrarPersona()
        {
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido(s): ");
            apellidos = Console.ReadLine();
            Console.Write("CURP: ");
            curp = Console.ReadLine();
            Console.Write("RFC: ");
            rfc = Console.ReadLine();
            Console.Write("Celular: ");
            cel = Console.ReadLine();
            Console.Write("Correo electrónico: ");
            correo = Console.ReadLine();
            if (!Directory.Exists(@".\Registros_De_Personas"))
            {
                Directory.CreateDirectory(@".\Registros_De_Personas");
            }
            Directory.CreateDirectory(@".\Registros_De_Personas\" + nombre);
            File.WriteAllText(@".\Registros_De_Personas\" + nombre + @" \datos.txt", nombre + "\r\n" + apellidos + "\r\n" + curp + "\r\n" + rfc + "\r\n" + cel + "\r\n" + correo + "\r\n");
            Console.WriteLine("Persona registrada exitosamente");
        }

        public void LeerDirectorios()
        {
            try
            {
                List<string> listaDirectorios = new List<string>(Directory.EnumerateDirectories(@".\Registros_De_Personas\" + nombre));

                foreach (String dir in listaDirectorios)
                {
                    Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
                }
                Console.WriteLine("{0} directories found.", listaDirectorios.Count);
                Console.WriteLine("Escribe el número de archivo que deseas abrir");
                directorio = Console.ReadLine();
                Console.WriteLine("");
                nombre = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[0];
                apellidos = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[1];
                curp = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[2];
                rfc = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[3];
                cel = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[4];
                correo = File.ReadAllLines(@".\Registros_De_Personas\" + directorio + @"\datos.txt")[5];
                Console.WriteLine(nombre);
                Console.WriteLine(apellidos);
                Console.WriteLine(curp);
                Console.WriteLine(rfc);
                Console.WriteLine(cel);
                Console.WriteLine(correo);
            }
            catch(IOException ioex)
            {
                Console.WriteLine("Error de System IO: " + ioex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.ToString()); ;
            }
        }
    }
}
