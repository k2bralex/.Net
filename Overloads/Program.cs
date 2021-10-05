using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    class IncorrectEnteringException : Exception {}

    struct Coefficient
    {
        public int A { get; set; }
        public int B { get; set; }

        public Coefficient(string str)
        {
            A = 0;
            B = 0;
            Parse(str);
        }
        public Coefficient(int a, int b)
        {
            A = a;
            B = b;
        }

        public Coefficient(Coefficient pair)
        {
            A = pair.A;
            B = pair.B;
        }
        public void Parse(string str)
        {
            if (str[1] == ' ')
            {
                string[] integers = str.Split(' ');
                A = Convert.ToInt32(integers[0]);
                B = Convert.ToInt32(integers[1]);
            }

            if (str[1] == ',')
            {
                string[] integers = str.Split(',');
                A = Convert.ToInt32(integers[0]);
                B = Convert.ToInt32(integers[1]);
            }
        }

        public override string ToString()
        {
            return $"[{A},{B}]";
        }
    }


    class Linear
    {
        private Coefficient _pair;
        public Coefficient Pair { get; set; }
        public Linear(string pair)
        {
            _pair = new Coefficient(pair);
        }

        public void DoLinear(int num)
        {
            if ((-_pair.A * num % _pair.B) == 0)
            {
                Console.WriteLine($"If X = {num} --> Solution pair: [{num},{-_pair.A * num / _pair.B}]");
            }
            if ((-_pair.B * num % _pair.A)==0)
            {
                Console.WriteLine($"If Y = {num} --> Solution pair: [{-_pair.B * num / _pair.A},{num}]");
            }
            else
            {
                Console.WriteLine($"No solution");
            }
        }

        public void Run(int num)
        {
            DoLinear(num);
        }

        public override string ToString()
        {
            return $"{Pair.ToString()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Coefficient num1 = new Coefficient(3,2);
            //Coefficient num2 = new Coefficient("2,3");
            //Coefficient num3 = new Coefficient("4,5");

            //Console.WriteLine(num1.ToString());
            //Console.WriteLine(num2.ToString());
            //Console.WriteLine(num3.ToString());

            //Linear lin1 = new Linear("2,1");
            //lin1.Run(1);

            Fraction f1 = new Fraction(3, 4);
            Fraction f3 = new Fraction();
            double a = 1.25;
            int b = 2;

            f3 = f1 + a;
            Console.WriteLine(f3);
            f1 = f3 + b;
            Console.WriteLine(f1);




            Console.ReadKey();

        }
}
}
