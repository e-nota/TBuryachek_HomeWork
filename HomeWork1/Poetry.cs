using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
   public  class Poetry : Fiction
    {
        public override void DisplaySection()
        {
            Console.WriteLine($"The book '{Name}' is fiction poetry");
        }
    }
}
