using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Client : User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Status { get; private set; }

        public Basket Basket { get; private set; }

        public Client(string name, string surname, uint age, Sex sex,
            string login, string password, string status, Basket basket) : base(name, surname, age, sex)
        {
            Login = login;
            Password = password;
            Status = status;
            Basket = basket;
        }

        public Client(string login, string password)
        {
            Login = login;
            Password = password;
            Basket = new Basket();
        }

        public void AddItem(Product product)
        {
            Basket.AddItem(product);
        }

        public void RemoveItem(Product product)
        {
            Basket.RemoveItem(product);
        }
    }
}
