using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public enum Sex { Male, Female }

    public class User
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public uint Age { get; private set; }
        public Sex Sex { get; private set; }

        public User()
        {

        }
        public User(string name, string surname, uint age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }
    }
}
