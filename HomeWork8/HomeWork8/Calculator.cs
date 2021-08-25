using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Calculator
    {
        public double GetSum (double a, double b)
        {
            return a + b;
        }
        public double GetSubstract (double a, double b)
        {
            return a - b;
        }

        public double GetMultiply (double a, double b)
        {
            return a * b;
        }
        public double GetDivide (double a, double b)
        {
            return Math.Round(a / b);
        }

    }
}
