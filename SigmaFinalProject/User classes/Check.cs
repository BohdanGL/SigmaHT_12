using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    class Check
    {
        public string ShopInfo { get; private set; }
        public List<Product> Products { get; private set; }
        public double TotalPrice { get; private set; }
        public DateTime Time { get; private set; }

        public Check(string shopInfo, List<Product> products, double totalPrice, DateTime time)
        {
            ShopInfo = shopInfo;
            Products = products;
            TotalPrice = totalPrice;
            Time = time;
        }
    }
}
