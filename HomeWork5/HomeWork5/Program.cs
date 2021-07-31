using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client() { FIO = "Ivanov", PassportNum = "Q123", Balance = 10 };
            Client client2 = new Client() { FIO = "Petrov", PassportNum = "Q124", Balance = 75.5 };
            Client client3 = new Client() { FIO = "Zaicev", PassportNum = "Q125", Balance = 150 };
            Client client4 = new Client() { FIO = "Volkova", PassportNum = "Q126", Balance = 1 };
            Client client5 = new Client() { FIO = "Ivanova", PassportNum = "Q127", Balance = 1 };

            List<Client> clients = new List<Client>();
            var array = new Client[] { client1, client2, client3, client4, client5 };
            clients.AddRange(array);

            //1.
            Console.WriteLine("Find client by FIO: ");
            string FindFIO = Console.ReadLine();
            var FoundClients = FindClientsByFIO(FindFIO.ToUpper(), clients);
            int CountFoundClients = FoundClients.Count();
            Console.WriteLine( $"Found {CountFoundClients} clients like {FindFIO} : \n ");

            foreach(var f in FoundClients)
            {
                Console.WriteLine($"{f.FIO} - passport {f.PassportNum}");
            }
            Console.WriteLine("---------\n");

            //2.
            double LimitBalance = 100;
            var LowBalClients = FindClientsLowBalance(LimitBalance, clients);
            Console.WriteLine($"Clients whith balance lower then {LimitBalance}:\n ");
            foreach(var l in LowBalClients)
            {
                Console.WriteLine($"{l.FIO} passport {l.PassportNum}, balance: {l.Balance}");
            }
            Console.WriteLine("---------\n");

            //3.
            double MinBalance = clients.Min(c => c.Balance);
            var MinBalClients = FindClientsMinBalance(MinBalance, clients);
            Console.WriteLine($"Clients whith min balance = {MinBalance}:\n ");
            foreach (var l in MinBalClients)
            {
                Console.WriteLine($"{l.FIO} passport {l.PassportNum}, balance: {l.Balance}");
            }
            Console.WriteLine("---------\n");

            //4. 
            double AllClientsBalance = clients.Sum(c => c.Balance);
            Console.WriteLine($"Balance all clients: {AllClientsBalance} \n");

        }

        public static IEnumerable<Client> FindClientsByFIO(string name, List<Client> clients)
        {
            return clients.Where(p => p.FIO.ToUpper().Contains(name)).OrderBy(p => p.FIO);
        }

        public static IEnumerable<Client> FindClientsLowBalance(Double limitbal, List<Client> clients)
        {
            return clients.Where(p => p.Balance.CompareTo(limitbal) < 0).OrderBy(p => p.Balance);
        }

        public static IEnumerable<Client> FindClientsMinBalance(Double minbal, List<Client> clients)
        {
            return clients.Where(p => p.Balance.CompareTo(minbal) == 0).OrderBy(p => p.Balance);
        }
    }
}
