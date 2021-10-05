using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    public class HouseholdChemicals : Consumer
    {
        private string _name;

        public string Name { get; set; }

        public HouseholdChemicals(double price, string manufacturer, string name) : base(price, manufacturer)
        {
            _name = Name;
        }

        public override string ToString()
        {
            return $"{base.ToString()} \t {Name}";
        }
    }
}