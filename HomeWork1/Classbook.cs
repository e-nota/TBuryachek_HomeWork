using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Classbook: Book
    {
        public int num_of_class { get; set; }
        public override void DisplayInfo()
        {
            if (num_of_class == 0)
                Console.WriteLine($"Classbook = '{Name}', author = {Author}, the year of publishing = {Year}");
            else 
                Console.WriteLine($"Classbook = '{Name} {num_of_class} class', author = {Author}, the year of publishing = {Year}");
        }
    }
}
