using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public abstract class Consumer : Product
    {
        private string _manufacturer;

        public string Manufacturer { get; set; }

        protected Consumer(double price, string manufacturer) : base(price)
        {
            _manufacturer = Manufacturer;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \t {Manufacturer}";
        }
    }
}