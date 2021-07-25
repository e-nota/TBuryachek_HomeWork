using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Novel  : Fiction
    {
        public override void DisplaySection()
        {
            Console.WriteLine($"The book '{Name}' is fiction novel");
        }
    }
}
