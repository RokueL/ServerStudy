//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    // 메서드를 Object로 쓰는 경우
//    class ThisLock
//    {
//        public void IncreaseCount(ref int count)
//        {
//            count++;
//        }
//    }

//    class Test
//    {
//        ThisLock lockObject = new ThisLock();
//        int Count;

//        public void ThreadPross()
//        {
//            lock (lockObject)
//            {
//                for (int i = 0; i < 3; i++)
//                {
//                    lockObject.IncreaseCount(ref Count);
//                    Console.WriteLine($"Thread1 id : {Thread.CurrentThread.GetHashCode()} result : {Count}");
//                }
//            }
//        }
//    }

//    class Syncro02
//    {


//        static void Main()
//        {
//            Test test = new Test();
//            Thread[] threads = new Thread[3];
//            for(int i = 0;i < threads.Length;i++)
//            {
//                threads[i] = new Thread(new ThreadStart(test.ThreadPross));
//            }
//            for (int i = 0; i < threads.Length; i++)
//            {
//                threads[i].Start();
//            }

//        }
//    }
//}
