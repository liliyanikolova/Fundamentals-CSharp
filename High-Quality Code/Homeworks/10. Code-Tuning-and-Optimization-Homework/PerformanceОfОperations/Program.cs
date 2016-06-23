//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PerformanceОfОperations
//{
//    using System.Diagnostics;

//    class Program
//    {
//        public static void Main(string[] args)
//        {

//        }

//        public static void AddInt(int number)
//        {
//            Stopwatch timer = new Stopwatch();
//            timer.Start();

//            for (int i = 0; i < 1000; i++)
//            {
//                number += 1;
//            }

//            timer.Stop();
//            Console.WriteLine(timer.Elapsed);
//        }
//    }
//}
