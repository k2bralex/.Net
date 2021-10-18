using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    class Rhombus : Shape
    {
        private double _alpha;
        private double SideLenght { get; set; }
        public double Alpha
        {
            get => _alpha;
            set
            {
                if (value>0 &&value <180)
                {
                    _alpha = value;
                }
                else
                {
                    Console.WriteLine("Fuck off");
                }
            }
        }

        public Rhombus(string name, double lenght, double alpha) : base(name)
        {
            SideLenght = lenght;
            Alpha = alpha;
        }

        public override double ShapeArea()
        {
            return Math.Sin(Alpha) * Math.Pow(SideLenght, 2);
        }

        public override double ShapePerimeter()
        {
            return SideLenght * QUADRANGLE_SIDES_QTY;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"  side a: {SideLenght}\n" +
                   $"  side b: {SideLenght}\n" +
                   $"  side c: {SideLenght}\n" +
                   $"  side d: {SideLenght}\n" +
                   $"  angle ab: {Alpha}";
        }
    }
}

