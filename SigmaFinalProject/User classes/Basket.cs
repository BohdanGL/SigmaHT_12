using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Basket
    {
        public List<Product> Products { get; private set; }
        public double TotalPrice { get; private set; }

        public double TotalWeight { get; private set; }

        public Basket(List<Product> products, double totalPrice)
        {
            Products = products;
            TotalPrice = totalPrice;
        }

        public Basket(List<Product> products)
        {
            Products = products;
            GetTotalPrice();
            GetTotalWeight();
        }

        public Basket()
        {
            Products = new List<Product>();
        }

        public Product this[int index]
        {
            get { return Products[index]; }
            set { Products.Add(value); }
        }

        public void AddItem(Product product)
        {
            Products.Add(product);
            TotalPrice += product.Price;
            TotalWeight += product.Weight;
        }

        public void RemoveItem(Product product)
        {
            Products.Remove(product);
            TotalPrice -= product.Price;
            TotalWeight -= product.Weight;
        }

        private void GetTotalPrice()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                TotalPrice += Products[i].Price;
            }
        }

        private void GetTotalWeight()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                TotalWeight += Products[i].Weight;
            }
        }
    }
}
