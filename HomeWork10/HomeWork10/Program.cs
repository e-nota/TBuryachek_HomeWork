using System;
using System.Threading;

namespace HomeWork10
{
    class Program
    {
        public static int num = 1;
        public static void Main(string[] args)
        {
            var job = new Job();

            for (int i = 0; i < 10; i++)
            {
                job.Add(DoSomething);
            }

            job.Start(3);
            Console.WriteLine("---");
            job.Start(2);
            Console.WriteLine("---");
            
            job.Stop();
            job.Start(5);
            Console.WriteLine("---");
            job.Clear();
            job.Start(2);
            Console.WriteLine("---");
        }

        public static void  DoSomething()
        {
            Console.WriteLine($"Action start {num}");
            Thread.Sleep(1000);
            num++;

        }
    }
}
