using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Thread05
    {
        static void Func1()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"스레드 1에서 호출 : {i}");
        }

        static void Func2()
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine($"스레드 2에서 호출 : {i}");
        }
        static void Main()
        {
            Thread th = new Thread(new ThreadStart(Func1));
            Thread th2 = new Thread(new ThreadStart(Func2));

            th.Start();
            th2.Start();

            Console.WriteLine($"메인종료");

        }
    }
}
