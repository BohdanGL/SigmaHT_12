using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Shop
    {
        public List<Client> Clients { get; private set; }
        public List<Administrator> Administrators { get; private set; }
        public List<Moderator> Moderators { get; private set; }
        public List<Order> Orders { get; private set; }
        public Storage Storage { get;  set; }


        private static Shop instance;

        private Shop()
        {
            Clients = new List<Client>();
            Administrators = new List<Administrator>();
            Moderators = new List<Moderator>();
            Orders = new List<Order>();
            Storage = new Storage();
        }

        public static Shop GetInstance()
        {
            if (instance == null)
                instance = new Shop();

            return instance;
        }

        public void AddClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
