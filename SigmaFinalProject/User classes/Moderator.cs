using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Moderator : User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public double Salary { get; private set; }


        public Moderator(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public Moderator(string name, string surname, uint age, Sex sex,
            string login, string password, double salary) : base(name, surname, age, sex)
        {
            Login = login;
            Password = password;
            Salary = salary;
        }
    }
}
