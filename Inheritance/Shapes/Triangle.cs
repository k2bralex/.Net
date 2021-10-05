using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Shapes.Constants;

namespace Inheritance.Shapes
{
    class Triangle : Shape
    {
        private double[] triangleArray = new double[TRIANGLE_SIDES_QTY];

        public Triangle(string name, double lenght1, double lenght2, double lenght3) :base(name)
        {
            triangleArray[0] = lenght1;
            triangleArray[1] = lenght2;
            triangleArray[2] = lenght3;
        }

        public double PoluPerimeter()
        {
            double poluPerimeter = 0;
            foreach (var side in triangleArray)
            {
                poluPerimeter += side;
            }

            return poluPerimeter / 2;
        }

        public override double ShapeArea()
        {
            double P = PoluPerimeter();
            double area = Math.Sqrt(P * (P - triangleArray[0])*
                                    (P - triangleArray[1])*
                                    (P - triangleArray[2]));
            return area;
        }

        public override double ShapePerimeter()
        {
            double perimeter = 0;
            foreach (var i in triangleArray)
            {
                perimeter += i;
            }
            return perimeter;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"  side a: {triangleArray[0]}\n" +
                   $"  side b: {triangleArray[1]}\n" +
                   $"  side c: {triangleArray[2]}";
        }
    }
}
