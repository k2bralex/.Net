using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_8
{
    public class Point2D<T>
    {
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }

        public override string ToString()
        {
            return $"[{X},{Y}]";
        }
    }

    class Point3D<T> : Point2D<T>
    {
        public T Z { get; set; }

        public Point3D(T x, T y, T z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"[ {base.X} ; {base.Y} ; {Z} ]";
        }
    }

    class Straight<T>
    {
        public Point2D<T> Point1 { get; set; }
        public Point2D<T> Point2 { get; set; }

        public Straight(T c1,T c2,T c3,T c4)
        {
            Point1 = new Point2D<T>(c1, c2);
            Point2 = new Point2D<T>(c3, c4);
        }
        public Straight(Point2D<T> p1, Point2D<T> p2)
        {
            Point1 = p1;
            Point2 = p2;
        }

        public override string ToString()
        {
            return $"Line: [ {Point1.ToString()} - {Point2.ToString()} ]";
        }
    }
}
