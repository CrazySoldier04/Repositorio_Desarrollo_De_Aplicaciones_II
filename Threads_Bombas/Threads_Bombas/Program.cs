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
        static Semaphore s = new Semaphore(1, 2);
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i++)
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
            Console.WriteLine("Estado: {0}", new ThreadState());
            Console.WriteLine("El carro: " + id + " salió de la bomba");
            s.Release();
            Thread.Sleep(1000);
            Console.WriteLine("Estado: {0}", new ThreadState());
        }
    }
}