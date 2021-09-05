using System;
using System.Diagnostics;
using System.Threading;

namespace HomeWork9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num10M = 10000000;
            int Num100M = 100000000;

            //Засекаем генерацию массива и подчсет среденего арифметического
            Console.WriteLine(" - - - 1 - - - ");
            Stopwatch timer = Stopwatch.StartNew();
            double average10M = CalculateAverage(Num10M);
            double average100M = CalculateAverage(Num100M);
            timer.Stop();
            Console.WriteLine($"Average 10M massive = {average10M}, averrage 100M massive = {average100M}." +
                $"Time for Creating and Calculating average massives 10M and 100M takes - {timer.ElapsedMilliseconds} ms ");

            //----
            Console.WriteLine(" - - - 2 - - - ");
            timer = Stopwatch.StartNew();
            var countdown = new CountdownEvent(2);
            double threadaverage10M = 0;
            double threadaverage100M = 0;

            ThreadPool.QueueUserWorkItem
            (
                new WaitCallback
                (
                    (_) =>
                    {
                        threadaverage10M = CalculateAverage(Num10M);
                        countdown.Signal();
                    }
                )
             );

            ThreadPool.QueueUserWorkItem
            (
               new WaitCallback
                (
                    (_) =>
                    {
                        threadaverage100M = CalculateAverage(Num100M);
                        countdown.Signal();
                    }
                )
             );

            countdown.Wait();
            timer.Stop();
            Console.WriteLine($"Average 10M massive = {threadaverage10M}, averrage 100M massive = {threadaverage100M}." +
                $"Time for Creating and Calculating average massives 10M and 100M takes - {timer.ElapsedMilliseconds} ms ");
        }


            static double CalculateAverage(int size)
            {
                Random rnd = new Random();
                var mass = new int [size];
                int s = size / 1000000;
                double sum = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(0, 10000+s);
                    sum = sum + mass[i];
                }
                double average = sum / mass.Length;
                
                return average;
            }
        
    }
}
