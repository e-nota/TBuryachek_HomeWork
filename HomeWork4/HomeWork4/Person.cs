using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class Person 
    {
        public string FIO { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string NumOfPassport { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || (!(obj is Person)))
            {
                return false;
            }

            Person person = (Person)obj;
            return person.FIO == FIO && person.DateOfBirth == DateOfBirth && person.PlaceOfBirth == PlaceOfBirth && person.NumOfPassport == NumOfPassport;
        }

        public override int GetHashCode()
        {
            return FIO.GetHashCode() + DateOfBirth.GetHashCode() + PlaceOfBirth.GetHashCode() + NumOfPassport.GetHashCode();
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(Person first, Person second)
        {
            return !first.Equals(second);
        }

    }
}
