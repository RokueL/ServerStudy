//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    class Test
//    {
//        /// <summary 크리티컬 영역에 가면 키로 쓰이는 것 </summary>
//        static object obj = new object();
//        static int Count;

//        public void ThreadTest()
//        {
//            lock (obj)
//            {
//                for (int i = 0; i < 10; i++)
//                {
//                    Count++;
//                    Console.WriteLine($"Thread1 id : {Thread.CurrentThread.GetHashCode()} result : {Count}");
//                }
//            }
//        }
//    }

//    class Syncro01
//    {


//        static void Main()
//        {
//            Test test = new Test();
//            Thread th = new Thread(new ThreadStart(test.ThreadTest));
//            Thread th2 = new Thread(new ThreadStart(test.ThreadTest));
//            th.Start();
//            th2.Start();

//        }
//    }
//}
