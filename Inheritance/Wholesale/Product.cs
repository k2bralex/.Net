using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Product
    {
        protected Product(double price)
        {
            Price = price;
        }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Price}";
        }


    }
}