using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    public class Order
    {
        public string Username { get; private set; }
        public double TotalPrice { get; private set; }
        public double TotalWeight { get; private set; }
        public string Address { get; set; }
        public DateTime OrderCreationTime { get; private set; }

        public Order(string username, string address, double totalPrice,
            double totalWeight, DateTime orderCreationTime)
        {
            Username = username;
            Address = address;
            TotalPrice = totalPrice;
            TotalWeight = totalWeight;
            OrderCreationTime = orderCreationTime;
        }
    }
}
