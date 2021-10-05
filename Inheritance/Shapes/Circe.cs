using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Shapes.Constants;

namespace Inheritance.Shapes
{
    class Circe : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public Circe(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double ShapeArea()
        {
            return 2 * PI * _radius;
        }

        public override double ShapePerimeter()
        {
            return PI * Math.Pow(_radius, 2);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nRadius: {Radius}";
        }
    }
}
