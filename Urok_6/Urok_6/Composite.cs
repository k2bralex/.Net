using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    enum ShapeType
    {
        Square, Triangle, Rhombus, Parallelogram
    }

    class Composite : Shape, SimpleNAngle
    {
        private List<Shape> shapesList = new List<Shape>();

        public Composite()
        {
            SidesLenght = new double[11];
        }

        public double Hight { get; set; }
        public double Base { get; set; }
        public double Angle { get; set; }
        public int SidesQuantity { get; set; }
        public double[] SidesLenght { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public override double ShapeArea()
        {
            double sum = 0;
            foreach (var shape in shapesList)
            {
                sum += shape.ShapeArea();
            }

            return sum;
        }

        public override double ShapePerimeter()
        {
            double per = 0;
            foreach (var shape in shapesList)
            {
                per += shape.ShapePerimeter();
            }

            return per;
        }

        public void GetShapes()
        {
            shapesList.Add(new Circe("Circle", 10));
            shapesList.Add(new Triangle("Triangle", 19, 22, 33));
            shapesList.Add(new Square("Square", 10));
            shapesList.Add(new Rhombus("Rhombus", 15, 45));
            shapesList.Add(new Parallelogram("Parallelogram", 10, 90, 30));
        }

        public void Draw()
        {
            foreach (var shape in shapesList)
            {
                Console.WriteLine(shape.ToString());
            }
        }

        public void Run()
        {
            GetShapes();
            Draw();
        }


    }
}