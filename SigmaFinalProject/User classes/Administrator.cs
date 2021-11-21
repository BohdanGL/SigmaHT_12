using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Administrator : User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public double Salary { get; private set; }

        public Administrator(string name, string surname, uint age, Sex sex,
            string login, string password, double salary) : base(name, surname, age, sex)
        {
            Login = login;
            Password = password;
            Salary = salary;
        }

        public Administrator(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public void AddProducts(Storage storage, List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                storage.Add(products[i]);
            }
        }

        public void RemoveProducts(Storage storage, List<Product> products)
        {
            for (int i = 0; i < products.Count; i++)
            {
                storage.Remove(products[i]);
            }
        }
    }
}
