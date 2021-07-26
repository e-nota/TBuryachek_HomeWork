using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Zoology : Biology
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Classbook of Biology. Zoology = '{Name} {NumOfClass} class', author = {Author}, the year of publishing = {Year}");
        }
    }
}
