using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Thread09
    {
    }
}
    //    static void Func1()
    //    {
    //        Console.WriteLine($"Thread1 id : {Thread.CurrentThread.GetHashCode()}");
    //        Thread th = new Thread(new ThreadStart(Func2));
    //        th.Start();
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.Write($"{i * 10} ");
    //            Thread.Sleep(200);

    //            if(i == 3)
    //            {
    //                Console.WriteLine($"Thread1 종료");
    //                Thread.CurrentThread.Abort();
    //            }
    //        }
    //    }

    //    static void Func2()
    //    {
    //        Console.WriteLine($"Thread2 id : {Thread.CurrentThread.GetHashCode()}");
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.Write($"{i} ");
    //            Thread.Sleep(200);
    //        }
    //        Console.WriteLine($"Thread2 종료");
    //    }

    //    static void Main()
    //    {
    //        Thread th = new Thread(new ThreadStart(Func1));
    //        th.Start();
    //        Console.WriteLine($"메인 스레드 {Thread.CurrentThread.GetHashCode()}");
    //        Console.WriteLine($"메인 종료");
    //    }
    //}
