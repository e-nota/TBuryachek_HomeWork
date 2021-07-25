using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Book = '{Name}', author = {Author}, the year of publishing = {Year}");

        }

        public void DisplayEdition()
        {
            string mess = "";
            if (Year >= 2000)
                mess = "New Edition";
            else
                mess = "Old Edition";
            Console.WriteLine($"The book '{Name}' is " + mess+" ");

        }


    }
}
