using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaFinalProject
{
    class DairyProducts : Product
    {
        public DairyProducts(string name, double price, double weight, int expiratioDate,
            DateTime productionDate)
            : base(name, price, weight, expiratioDate, productionDate)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            DairyProducts dairy_Products = (DairyProducts)obj;
            return (this.ExpirationDate == dairy_Products.ExpirationDate);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void ChangePrice(double percentage)
        {
            base.ChangePrice(percentage);

            if (percentage > 0)
            {
                Price += ExpirationDate * 5 * Price / 100;
            }
            else if (percentage < 0)
            {
                Price -= ExpirationDate * 5 * Price / 100;
            }
            else
            {
                return;
            }
        }
    }
}
