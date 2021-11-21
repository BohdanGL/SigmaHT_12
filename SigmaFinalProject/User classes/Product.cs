using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int ExpirationDate { get; set; }
        public DateTime ProductionDate { get; set; }

        public Product(string name, double price, double weight, int expirationDate, DateTime productionDate)
        {
            Name = name;
            Price = price;
            Weight = weight;
            ExpirationDate = expirationDate;
            ProductionDate = productionDate;
        }

        public bool IsExpired()
        {
            return ProductionDate.AddDays(ExpirationDate) < DateTime.Now;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Product product = (Product)obj;
            return (this.Name == product.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nWeight: {Weight}\n" +
                $"Expiration date: {ExpirationDate}\nProduction date: {ProductionDate}\n";
        }

        public virtual void ChangePrice(double percentage)
        {
            Price += percentage * Price / 100;
        }
    }
}
