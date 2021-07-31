using System;
using System.Collections.Generic;

namespace Clients
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client() { FIO = "Ivanov", PassportNum = "Q123", cash = 0 };
            Client client2 = new Client() { FIO = "Petrov", PassportNum = "Q124", cash = 15.5 };
            Client client3 = new Client() { FIO = "Zaicev", PassportNum = "Q125", cash = 122.74 };
            Client client4 = new Client() { FIO = "Volkova", PassportNum = "Q126", cash = 500  };
            Client client5 = new Client() { FIO = "Ivanova", PassportNum = "Q127", cash = 0.2 };

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
          /*      if (clients[i].Equals(NewClient))
                {
                    Console.WriteLine(" This person also exist! ");
                    return;
                }
*/
                if (clients.Contains(NewClient))
                {
                    Console.WriteLine(" This person also exist! ");
                    return;
                }

            }
            Console.WriteLine(" Cash: ");
            string NewCash = Console.ReadLine();
            NewClient.cash = double.Parse(NewCash);
            clients.Add(NewClient);

            Console.WriteLine("Person succsesfuly added. ");

        }
    }
}
