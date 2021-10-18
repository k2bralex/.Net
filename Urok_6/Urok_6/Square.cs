using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    class Square : Shape
    {
        private double _alpha = 90;
        private double SideLenght { get; set; }
        public double Alpha { get; }

        public Square(string name, double lenght) : base(name)
        {
            SideLenght = lenght;
        }

        public override double ShapeArea()
        {
            return  Math.Pow(SideLenght, 2);
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
                   $"  side d: {SideLenght}\n";
        }
    }
}
