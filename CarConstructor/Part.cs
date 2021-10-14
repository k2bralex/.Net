using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstructor
{
    //класс запчасть из  которых собирается машина
    class Part
    {
        public string Name { get; set; }

        public Part(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"[{Name}]";
        }
    }
}
