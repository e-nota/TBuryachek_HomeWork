using System;
using System.Diagnostics;
using System.IO;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            var timerbox = Stopwatch.StartNew();
            // boxing
            for (int i=1; i<=n; i++)
            {
                object obj =  i;
            }
            timerbox.Stop();
            TimeSpan tsbox = timerbox.Elapsed;

            string text = "Boxing time: " + tsbox + " for n=" + n.ToString() + " operations";
            Console.WriteLine(text);

            using (StreamWriter sw = new StreamWriter (@"D:\BoxingTimer.txt", true) )
            {
                sw.WriteLine(text);
            }

                object num = n;
            var timerunbox = Stopwatch.StartNew();
            //unboxing
            for (int i = 1; i <= n; i++)
            {
                int j = (int)num;
            }
            timerunbox.Stop();
            TimeSpan tsunbox = timerunbox.Elapsed;
            string text1 = "Unboxing time: " + tsunbox + " for n=" + n.ToString()+ " operations";
            Console.WriteLine(text1);

            using (StreamWriter sw = new StreamWriter(@"D:\UnboxingTimer.txt", true))
            {
                sw.WriteLine(text1);
            }

        }
    }
}
