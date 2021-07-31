using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Client
    {
        public string FIO { get; set; }
        public double Balance { get; set; }
        public string PassportNum { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Client))
            {
                return false;
            }

            Client result = (Client)obj;
            return result.FIO == FIO && result.PassportNum == PassportNum;

        }
    }
}
