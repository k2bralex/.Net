using System;

namespace Urok_6
{
    class Triangle : Shape
    {
        private double[] _triangleArray = new double[TRIANGLE_SIDES_QTY];

        public Triangle(string name, double lenght1, double lenght2, double lenght3) :base(name)
        {
            if (lenght1 + lenght2 < lenght3 ||
                lenght1 + lenght3 < lenght2 ||
                lenght3 + lenght2 < lenght1)
            {
                Console.WriteLine("Fuck off");
            }
            else
            {
                _triangleArray[0] = lenght1;
                _triangleArray[1] = lenght2;
                _triangleArray[2] = lenght3;
            }
        }

        public double PoluPerimeter()
        {
            double poluPerimeter = 0;
            foreach (var side in _triangleArray)
            {
                poluPerimeter += side;
            }

            return poluPerimeter / 2;
        }

        public override double ShapeArea()
        {
            double P = PoluPerimeter();
            double area = Math.Sqrt(P * (P - _triangleArray[0])*
                                    (P - _triangleArray[1])*
                                    (P - _triangleArray[2]));
            return area;
        }

        public override double ShapePerimeter()
        {
            double perimeter = 0;
            foreach (var i in _triangleArray)
            {
                perimeter += i;
            }
            return perimeter;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"  side a: {_triangleArray[0]}\n" +
                   $"  side b: {_triangleArray[1]}\n" +
                   $"  side c: {_triangleArray[2]}";
        }
    }
}
