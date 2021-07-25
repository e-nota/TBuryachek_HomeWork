using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Fiction :Book
    {
        public override void DisplayInfo()
        {
            Console.WriteLine($"Fiction Book = '{Name}', author = {Author}, the year of publishing = {Year}");
        }

        public virtual void DisplaySection()
        {
            Console.WriteLine($"The book '{Name}' is fiction");
        }
    }
}
