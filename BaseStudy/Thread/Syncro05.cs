using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Syncro05
    {
        static Mutex mutex = new Mutex();
        static int Count;

        static void ThreadProc()
        {
            mutex.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Count++;
                Console.WriteLine($"Thread1 id : {Thread.CurrentThread.GetHashCode()} result : {Count}");
            }
            mutex.ReleaseMutex();
        }

        static void Main()
        {
            Thread th = new Thread(new ThreadStart(ThreadProc));
            Thread th2 = new Thread(new ThreadStart(ThreadProc));
            th.Start();
            th2.Start();
        }
    }
}
