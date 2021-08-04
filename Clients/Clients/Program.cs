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
           

            Lei lei = new Lei() { rate = 1.1 };
            Rubl rubl = new Rubl() { rate = 0.22 };
            Grivna grivna = new Grivna() { rate = 0.65 };
            Dollar dol = new Dollar() { rate = 16 };
            
            // --- Few accounts for one client ---
            Account account1lei = new Account() { currency = lei, cash = 100 };
            Account account1rub = new Account() { currency = rubl, cash = 50 };
            Account account1grn = new Account() { currency = grivna, cash = 200 };
            Account account2grn = new Account() { currency = grivna, cash = 10.5 };
            Account account3lei = new Account() { currency = lei, cash = 278 };
            Account account4rub = new Account() { currency = rubl, cash = 1000 };
            Account account4dol = new Account() { currency = dol, cash = 50 };
            Account account5rub = new Account() { currency = rubl, cash = 1 };

            List<Account> account1 = new List<Account> { account1lei, account1rub, account1grn };
            List<Account> account2 = new List<Account> { account2grn };
            List<Account> account3 = new List<Account> { account3lei };
            List<Account> account4 = new List<Account> { account4rub, account4dol};
            List<Account> account5 = new List<Account> { account5rub };

            Dictionary<Client, List<Account>> ClientBalance = new Dictionary<Client, List<Account>>
            {
                {client1, account1 },
                {client2, account2 },
                {client3, account3 },
                {client4, account4 },
                {client5, account5 }
            };

            // ------

            var CurrencyFrom = new Rubl() { rate = 11.5 };
            var CurrencyTo = new Dollar() { rate = 2 };
            
            decimal summ = CurrencyConverter(CurrencyFrom, CurrencyTo, 10);

        }
        public static decimal CurrencyConverter(Currency valin,  Currency valout, decimal sumin)
        {
            return Convert.ToDecimal((Convert.ToDouble(sumin) * valin.rate) / valout.rate);
        }
    }
}
