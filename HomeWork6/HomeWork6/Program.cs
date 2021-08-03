using System;
using System.Collections.Generic;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> LFigures = new List<Figure>();
            Dictionary<Figure, string> DFigures = new Dictionary<Figure, string>();

            Random rnd = new Random();
            int count = 100000;
            for (int i = 1; i <= count; i++)
            {
                var newfigure = new Figure() { SideCount = rnd.Next(3, 100), SideLength = rnd.Next(1, 10000) };

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
        }
    }
}
