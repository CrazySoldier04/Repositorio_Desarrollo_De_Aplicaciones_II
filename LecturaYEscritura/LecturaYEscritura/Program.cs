using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LecturaYEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            String startUpPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            File.AppendAllText(startUpPath + @".\arch.dog", "Gracias por las recientes lluvias SEÑOR");
            Console.WriteLine(File.ReadAllText("arch.dog"));
            Console.ReadKey();
            
            foreach (String file in Directory.GetFileSystemEntries(startUpPath))
            {
                if (file.EndsWith(".dog"))
                {
                    if (Directory.Exists("la lola de la lola"))
                    {
                        File.Copy(startUpPath + (@"\la lola de la lola\arch.dog"), file);
                    }
                    else
                    {
                        Directory.CreateDirectory(startUpPath + @"/La lola de la lola");
                    }
                }
                Console.WriteLine("Archivo" + file);
            }
            Console.ReadKey();
        }
    }
}