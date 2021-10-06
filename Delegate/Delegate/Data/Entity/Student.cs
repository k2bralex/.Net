using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate.Data.Entity
{
    class Student
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
