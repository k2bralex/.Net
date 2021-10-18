using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    class Parallelogram:Shape
    {
        private double _alpha;
        private double FirstPairSideLenght { get; set; }
        private double SecondPairSideLenght { get; set; }
        public double Alpha
        {
            get => _alpha;
            set
            {
                if (value > 0 && value < 180)
                {
                    _alpha = value;
                }
                else
                {
                    Console.WriteLine("Fuck off");
                }
            }
        }

        public Parallelogram(string name, double firstSide, double secondSide, double alpha) : base(name)
        {
            FirstPairSideLenght=firstSide;
            SecondPairSideLenght = secondSide;
            Alpha = alpha;
        }

        public override double ShapeArea()
        {
            return Math.Sin(Alpha) * 
                   FirstPairSideLenght * 
                   SecondPairSideLenght;
        }

        public override double ShapePerimeter()
        {
            return FirstPairSideLenght * SecondPairSideLenght * 2;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                   $"  side a-c: {FirstPairSideLenght}\n" +
                   $"  side b-d: {SecondPairSideLenght}\n" +
                   $"  angle ab: {Alpha}";
        }
    }
}

