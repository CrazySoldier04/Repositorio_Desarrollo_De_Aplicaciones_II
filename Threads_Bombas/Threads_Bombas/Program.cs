using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads_Bombas
{
    class Program
    {
        static Semaphore s = new Semaphore(1, 3);
        static void Main(string[] args)
        {
            for (int i = 1; i < 4; i++)
            {
                new Thread(Program.Metodo).Start(i);
            }
            Console.ReadKey();
        }
        static void Metodo(object id)
        {
            Console.WriteLine("El carro: " + id + " quiere echar gasolina");
            s.WaitOne();
            Console.WriteLine("El carro: " + id + " entró a la bomba de gasolina");
            Thread.Sleep(1000);
            Console.WriteLine("El carro: " + id + " escaneó el codigo qr");
            Console.WriteLine("El carro: " + id + " está cargando gasolina");
            //Console.WriteLine("Estado: {0}", new ThreadState());
            Console.WriteLine("El carro: " + id + " terminó de cargar gasolina");
            Console.WriteLine("El carro: " + id + " salió de la bomba \r\n");
            s.Release();
            Thread.Sleep(1000);
            //Console.WriteLine("Estado: {0}", new ThreadState());
        }
    }
}