using System;
using System.Collections.Generic;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client() { FIO = "Ivanov", PassportNum = "Q123" };
            Client client2 = new Client() { FIO = "Petrov", PassportNum = "Q124"};
            Client client3 = new Client() { FIO = "Zaicev", PassportNum = "Q125" };
            Client client4 = new Client() { FIO = "Volkova", PassportNum = "Q126"};
            Client client5 = new Client() { FIO = "Ivanova", PassportNum = "Q127"};
/*
            List<Client> clients = new List<Client>();
            var array = new Client[] { client1, client2, client3, client4, client5 };
            clients.AddRange(array);

            Console.WriteLine("New client. \n FIO: ");
            string NewFIO = Console.ReadLine();
            Console.WriteLine(" PassportNum: ");
            string NewPassportNum = Console.ReadLine();
            Client NewClient = new Client() { FIO = NewFIO, PassportNum = NewPassportNum };
            for (int i = 0; i < clients.Count; i++)
            {
            if (clients[i].Equals(NewClient))
                {
                    Console.WriteLine(" This person also exist! ");
                    return;
                }

                if (clients.Contains(NewClient))
                {
                    Console.WriteLine(" This person also exist! ");
                    return;
                }

            }
            Console.WriteLine(" Cash: ");
            string NewCash = Console.ReadLine();

            clients.Add(NewClient);

            Console.WriteLine("Person succsesfuly added. ");
*/
           

            Lei lei = new Lei() { rate = 0.5 };
            Rubl rubl = new Rubl() { rate = 0.2 };
            Grivna grivna = new Grivna() { rate = 0.25 };

            Account account1 = new Account() { currency = lei, cash = 100 };
            Account account2 = new Account() { currency = grivna, cash = 10.5 };
            Account account3 = new Account() { currency = lei, cash = 278 };
            Account account4 = new Account() { currency = rubl, cash = 1000 };
            Account account5 = new Account() { currency = rubl, cash = 1 };

            Dictionary<Client, Account> ClientBalance = new Dictionary<Client, Account>
            {
                {client1, account1 },
                {client2, account2 },
                {client3, account3 },
                {client4, account4 },
                {client5, account5 }
            };

            /*
            Dictionary<string, double> CourseDollar = new Dictionary<string, double>
           {
               {"RUB", 2},
               {"LEI", 3},
               {"GRN", 4}
           };

            Dictionary<string, double> CourseRubl = new Dictionary<string, double>
           {
               {"DOL", 5},
               {"LEI", 6},
               {"GRN", 7}
           };

            Dictionary<string, double> CourseGrn = new Dictionary<string, double>
           {
               {"DOL", 8},
               {"LEI", 9},
               {"RUB", 9.5}
           };

            Dictionary<string, double> CourseLei = new Dictionary<string, double>
           {
               {"DOL", 10},
               {"RUB", 11},
               {"GRN", 12}
           };
*/

            var CurrencyFrom = new Rubl() { rate = 11.5 };
            var CurrencyTo = new Dollar() { rate = 1 };
            
            decimal summ = CurrencyConverter(CurrencyFrom, CurrencyTo, 100);

        }
        public static decimal CurrencyConverter(Currency valin,  Currency valout, decimal sumin)
        {
            return Convert.ToDecimal((Convert.ToDouble(sumin) * valin.rate) / valout.rate);
        }
    }
}
