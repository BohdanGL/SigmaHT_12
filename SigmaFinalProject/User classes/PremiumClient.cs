using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class PremiumClient : Client
    {
        public PremiumClient(string name, string surname, uint age, Sex sex,
            string login, string password, string status, Basket basket) : base(name, surname, age, sex,
                 login, password, status, basket)
        {

        }

        public void GetFreeDelivery()
        {

        }
    }
}
