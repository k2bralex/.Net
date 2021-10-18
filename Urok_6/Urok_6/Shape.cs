namespace Urok_6
{
    abstract class Shape
    {
        public const int TRIANGLE_SIDES_QTY = 3;
        public const int QUADRANGLE_SIDES_QTY = 4;
        public const double PI = 3.14;

        string _name;
        public string Name { get; set; }

        public Shape(string name = "NoName")
        {
            Name = name;
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
