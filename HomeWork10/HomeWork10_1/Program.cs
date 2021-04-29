using System;
using System.Threading;

namespace HomeWork10_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var thread = new Thread(o => Console.WriteLine("第一个线程"));
            thread.Start();
            Console.WriteLine("main 线程");


        }
    }
}