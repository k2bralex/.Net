using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    class Ellipse : Shape
    {
        public double SemiMajorAxis { get; set; }
        public double SemiMinorAxis { get; set; }
        public override double ShapeArea()
        {
            return 2 * PI * SemiMajorAxis * SemiMinorAxis;
        }
        public override double ShapePerimeter()
        {
            return 4 * (((PI * SemiMajorAxis * SemiMinorAxis) +
                         Math.Pow(SemiMajorAxis - SemiMinorAxis, 2)) /
                        (SemiMajorAxis + SemiMinorAxis));
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSemi-Major Axis: {SemiMajorAxis}" +
                   $"\nSemi-Minor Axis: {SemiMinorAxis}";
        }
    }
}
