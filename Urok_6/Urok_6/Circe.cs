using System;

namespace Urok_6
{
    class Circe : Shape
    {
        public double Radius { get; set; }

        public Circe(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double ShapeArea()
        {
            return 2 * PI * Radius;
        }

        public override double ShapePerimeter()
        {
            return PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nRadius: {Radius}";
        }
    }
}
