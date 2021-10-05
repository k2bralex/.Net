using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Shapes
{
    abstract class Shape
    {
        string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public Shape(string name = "NoName")
        {
            _name = name;
        }

        public abstract double ShapeArea();
        public abstract double ShapePerimeter();
        public override string ToString()
        {
            return $"\nShape: {Name}\n------------------\n" +
                   $"Area: {ShapeArea()}\nPerimeter: { ShapePerimeter()}";
        }
    }
}
