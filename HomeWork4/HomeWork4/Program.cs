using System;
using System.Collections.Generic;

namespace HomeWork4
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.Check operator "==" for type string
           /* string str1 = "TestText1";
            string str2 = "TestText1";
            string str3 = "TestText2";

            bool status1 = str1 == str2;
            bool status2 = str1 == str3;

            bool status3 = str1.Equals(str2);
            bool status4 = str1.Equals(str3);
           */

            //2.
            Person person1 = new Person() {FIO = "Ivanov I.P.", DateOfBirth = new DateTime(1998, 02, 15), PlaceOfBirth = "Tiraspol",  NumOfPassport = "IPR-12345"};
            Person person2 = new Person() {FIO = "Petrov A.R.", DateOfBirth = new DateTime(2000, 01, 01), PlaceOfBirth = "Moscow", NumOfPassport = "IPR-54321" };
            Person person3 = new Person() {FIO = "Ivanov I.P.", DateOfBirth = new DateTime(1998, 02, 15), PlaceOfBirth = "Tiraspol", NumOfPassport = "IPR-12345" };
            Person person4 = person1;

            bool status1 = person1.Equals(person1);
            bool status2 = person1.Equals(person2);
            bool status3 = person1.Equals(person3);
            bool status4 = person1.Equals(person4);

            int hash1 = person1.GetHashCode();
            int hash2 = person2.GetHashCode();
            int hash3 = person3.GetHashCode();
            int hash4 = person4.GetHashCode();

            //3.
            bool status5 = person1 == person1;
            bool status6 = person1 == person2;
            bool status7 = person1 == person3;
            bool status8 = person1 == person4;

            string txt = "Person1 = " + person1.FIO + ", date of birth:" + person1.DateOfBirth + ", place of birth:" 
                        + person1.PlaceOfBirth + ", number of passport:" + person1.NumOfPassport +"\n";

            txt += "Person2 = " + person2.FIO + ", date of birth:" + person2.DateOfBirth + ", place of birth:"
                        + person2.PlaceOfBirth + ", number of passport:" + person2.NumOfPassport + "\n";

            txt += "Person3 = " + person3.FIO + ", date of birth:" + person3.DateOfBirth + ", place of birth:"
            + person3.PlaceOfBirth + ", number of passport:" + person3.NumOfPassport + "\n";

            txt += "Person4 = " + person4.FIO + ", date of birth:" + person4.DateOfBirth + ", place of birth:"
            + person4.PlaceOfBirth + ", number of passport:" + person4.NumOfPassport + "\n";


            txt += "person1.Equals(person1) = " + status1 + " \n";
            txt += "person1.Equals(person2) = " + status2 + " \n";
            txt += "person1.Equals(person3) = " + status3 + " \n";
            txt += "person1.Equals(person4) = " + status4 + " \n";

            txt += "Hashcode person1 =" + hash1 + " \n";
            txt += "Hashcode person2 =" + hash2 + " \n";
            txt += "Hashcode person3 =" + hash3 + " \n";
            txt += "Hashcode person4 =" + hash4 + " \n";

            txt += "person1 == person1 = " + status5 + "\n";
            txt += "person1 == person2 = " + status6 + "\n";
            txt += "person1 == person3 = " + status7 + "\n";
            txt += "person1 == person4 = " + status8 + "\n";

            Console.WriteLine(txt);

        }
    }
}
