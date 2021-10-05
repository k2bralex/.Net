using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ShapeType
{
    Circle, Triangle
}

namespace Inheritance.Shapes
{
    class Composite : Shape
    {
        private static int _capacity;

        static Composite()
        {
            _capacity = Capacity;
        }
        public static int Capacity
        {
            get => _capacity;
            set => _capacity = value;
        }

        public Shape [] _compositeShape;

        public Composite(string name):base(name)
        {
            _compositeShape = new Shape[_capacity];
        }

        public void FillComposite(string typeShape)
        {
            for (int i = 0; i < _compositeShape.Length; i++)
            {
                if (typeShape == "Cirlce")
                {
                    _compositeShape[i] = new Circe("Cirlce", 22);
                }
                if (typeShape == "Triangle")
                {
                    _compositeShape[i] = new Triangle("Triangle",
                        22,12,24);
                }
            }

        }

        public override double ShapeArea()
        {
            double area=0;
            foreach (Shape shape in _compositeShape)
            {
                if (shape is Triangle)
                {
                    area += (shape as Triangle).ShapeArea();
                }
                if (shape is Triangle)
                {
                    area += (shape as Triangle).ShapeArea();
                }
            }

            return area;
        }

        public override double ShapePerimeter()
        {
            throw new NotImplementedException();
        }

    }
}
