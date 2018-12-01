using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos_Monitor_Lock
{
    class Program
    {
        //mutex 
        private static Mutex mutex = new Mutex();
        private const int numhits = 1;
        private const int numThreads = 4;
        private static void ThreadProcess()
        {
            for (int i = 0; i < numhits; i++)
            {
                PorMutex();
            }
        }
        private static void PorMutex()
        {
            mutex.WaitOne();   // Wait until it is safe to enter.
            Console.WriteLine("{0} ha entrado a la sección critica mutex", Thread.CurrentThread.Name);
            // Place code to access non-reentrant resources here.
            Thread.Sleep(500);    // Wait until it is safe to enter.
            Console.WriteLine("{0} ha entrado a la sección critica mutex \r\n", Thread.CurrentThread.Name);
            mutex.ReleaseMutex();    // Release the Mutex.
        }

        //Monitor
        static readonly object _object = new object();
        public static void PrintNumbers()
        {
            //monitor
            Monitor.Enter(_object);
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(Thread.CurrentThread.Name + " monitor " + i + ",");
                }
                Console.WriteLine();
            }
            finally
            {
                Monitor.Exit(_object);
            }
        }

        static void TestLock()
        {

            lock (_object)
            {
                Thread.Sleep(100);
                Console.WriteLine(Thread.CurrentThread.Name + " monitor " + Environment.TickCount);
            }
        }

        //semaforo
        static Thread[] threads = new Thread[10];
        static Semaphore sem = new Semaphore(3, 3);
        static void PorSemaforo()
        {
            Console.WriteLine("{0} esperando en cola semaforo...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} entrando a la secciòn critica semaforo!", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} dejando  a la secciòn critica semaforo", Thread.CurrentThread.Name);
            sem.Release();
        }

        static void Main(string[] args)
        {
            //mutex
            for (int i = 0; i < numThreads; i++)
            {
                Thread hilosMutex = new Thread(new ThreadStart(ThreadProcess));
                hilosMutex.Name = String.Format("mutex Thread{0}", i + 1);
                hilosMutex.Start();
            }
            //monitor
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(new ThreadStart(PrintNumbers));
                Threads[i].Name = "monitor hijo " + i;
            }
            foreach (Thread t in Threads)
                t.Start();
            //semaforo
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(PorSemaforo);
                threads[i].Name = "semaforo thread_" + i;
                threads[i].Start();
            }
            Console.ReadKey();
        }
    }
}