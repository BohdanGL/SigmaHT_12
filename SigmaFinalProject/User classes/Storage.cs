using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Storage
    {
        public delegate void Operation(List<Product> products, string fileName);

        public event Operation SearchForExpiredProducts;
        public List<Product> Products { get; private set; }

        public Storage()
        {
            Products = new List<Product>();
        }

        public Storage(List<Product> products)
        {
            Products = products;
        }

        public Product this[int index]
        {
            get { return Products[index]; }
            set { Products.Add(value); }
        }

        public override string ToString()
        {
            SearchForExpiredProducts?.Invoke(Products, "LogStorage.txt");

            string output = "\nProducts in the storage:";

            for (int i = 0; i < Products.Count; i++)
            {
                output += $"\n\n--- {i + 1} product ---\n";
                output += Products[i];
            }

            return output;
        }

        public List<Product> FindAllMeatProducts()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetType() == typeof(Meat))
                    products.Add(Products[i]);
            }

            return products;
        }

        public List<Product> FindAllExpiredProducts()
        {
            return Products.FindAll(i => i.IsExpired() == true);
        }

        public void ChangePriceForAllProducts(double percentage)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Products[i].ChangePrice(percentage);
            }
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove(Product product)
        {
            Products.Remove(product);
        }

        public List<Product> FindProductsByPrice(double price)
        {
            return Products.FindAll(i => i.Price == price);
        }
    }
}
