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
            Thread.Sleep(2000);
            Console.WriteLine("\r\n");
            Console.WriteLine("El carro: " + id + " entró a la bomba de gasolina");
            Thread.Sleep(2000);
            Console.WriteLine("El carro: " + id + " escaneó el codigo qr");
            Thread.Sleep(3000);
            Console.WriteLine("El carro: " + id + " está cargando gasolina");
            Console.WriteLine("Hilo: " + Thread.CurrentThread.ThreadState);
            Thread.Sleep(5000);
            Console.WriteLine("El carro: " + id + " terminó de cargar gasolina");
            Console.WriteLine("El carro: " + id + " salió de la bomba \r\n");
            Console.WriteLine("Bomba de gasolina esta libre \r\n");
            s.Release();
            Thread.Sleep(2000);
            //Console.WriteLine("Estado: {0}", new ThreadState());
        }
    }
}