using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {
        public static int Num100M = 100000000;
        public static int[] mass100M = new int[Num100M];
        public static double summa = 0;

        static void Main(string[] args) 
        {
            // Заполнение массива 
            mass100M = CreateRandomMassive();

            // Подсчёт среденего арифметического последовательно
            Console.WriteLine(" - - - 1 - - - ");
            Stopwatch timer = Stopwatch.StartNew();
            //double average100M = CalculateAverage(Num100M);
            CalculateAverage(Num100M);
            timer.Stop();
            Console.WriteLine(//$"Average 100M massive = {average100M}." +
                $"Time for Calculating average massive 100M takes - {timer.ElapsedMilliseconds} ms ");

            // Подсчёт среденего арифметического параллельно
            Console.WriteLine(" - - - 2 - - - ");
            timer = Stopwatch.StartNew();
           // double average100Mparallel =   
           // Parallel.For(99999, 100000, CalculateAverage);
           // Parallel.For(999999, 1000000, CalculateAverage);
           // Parallel.For(99999999, 100000000, CalculateAverage);
           // Parallel.For(100000000, 100000001, CalculateAverage);

            // 
            summa = 0;
            Parallel.For(1, Num100M, Sum);
            double average = summa / mass100M.Length;

            Console.WriteLine($"Average 100M massive = {average}." +
               $"Time for parallel Calculating average massive 100M takes - {timer.ElapsedMilliseconds} ms ");

        }

        static int[] CreateRandomMassive()
        {
            Random rnd = new Random();
            for (int i = 0; i < mass100M.Length; i++)
            {
                mass100M[i] = rnd.Next(0, 1000);
            }
            return mass100M;
        }

        private static void CalculateAverage(int size)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum = sum + mass100M[i];
            }
            double average = sum / mass100M.Length;
            Console.WriteLine($"Averrage massive = {average}");
            //return average;
        }

        private static void Sum(int number)
        {
            summa = summa + mass100M[number];
           // Console.WriteLine($"{mass100M[number]}__{summa}");
        }


    }
}