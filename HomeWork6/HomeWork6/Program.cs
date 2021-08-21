using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> LFigures = new List<Figure>();
            Dictionary<Figure, string> DFigures = new Dictionary<Figure, string>();

            Random rnd = new Random();
            int count = 10000;
            for (int i = 1; i <= count; i++)
            {
                var newfigure = new Figure() { SideCount = rnd.Next(3, 1000), SideLength = rnd.Next(1, 10000) };

                if (!LFigures.Contains(newfigure))
                {
                    LFigures.Add(newfigure);
                    DFigures.Add(newfigure, $"{newfigure.SideCount}-угольник");
                }
                else
                {
                    count++;
                }
            }

            Figure SearchFigure = new Figure();
            SearchFigure = LFigures[LFigures.Count - 2];
            Figure result = new Figure();

            // Searching in List
            var timerfindlist = Stopwatch.StartNew();
            foreach (var item in LFigures)
            {
                if (item.Equals(SearchFigure))
                {
                    result = item;
                    break;
                }
            }
            timerfindlist.Stop();
            Console.WriteLine($"Figure searching in list takes {timerfindlist.Elapsed} ms");

            // Searching in Dictionary
            var timerfinddict = Stopwatch.StartNew();
            foreach (var item in DFigures.Keys)
            {
                if (item.Equals(SearchFigure))
                {
                    result = item;
                    break;
                }
            }
            timerfinddict.Stop();
            Console.WriteLine($"Figure searching in dictionary takes {timerfinddict.Elapsed} ms");

        }
    }
}
