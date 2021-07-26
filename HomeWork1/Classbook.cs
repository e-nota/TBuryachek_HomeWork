using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Classbook: Book
    {
        public int NumOfClass { get; set; }
        public override void DisplayInfo()
        {
            if (NumOfClass == 0)
                Console.WriteLine($"Classbook = '{Name}', author = {Author}, the year of publishing = {Year}");
            else 
                Console.WriteLine($"Classbook = '{Name} {NumOfClass} class', author = {Author}, the year of publishing = {Year}");
        }
    }
}
