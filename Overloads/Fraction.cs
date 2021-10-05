using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    class Fraction
    {
        public int Num { get; set; }
        public int Den { get; set; }

        public Fraction()
        {
            
        }
        public Fraction(int num,int den)
        {
            Num = num;
            Den = den;
        }

        public override string ToString()
        {
            return $"{Num}/{Den}";
        }

        public static Fraction operator+(Fraction fraction1, Fraction fraction2)
        {
            Fraction res = new Fraction(fraction1.Num * fraction2.Den + fraction2.Num * fraction1.Den,
                fraction1.Den * fraction2.Den);
            return res;
        }

        public static Fraction operator +(Fraction fraction1, int value)
        {
            Fraction res = new Fraction(fraction1.Num + fraction1.Den*value, fraction1.Den);
            return res;
        }

        public static Fraction operator +(int value, Fraction fraction1)
        {
            Fraction res = new Fraction(fraction1.Num + fraction1.Den * value, fraction1.Den);
            return res;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction res = new Fraction(fraction1.Num * fraction2.Den - fraction2.Num * fraction1.Den,
                fraction1.Den * fraction2.Den);
            return res;
        }

        public static Fraction operator +(Fraction fraction1, double value)
        {
            double num = value * 100;
            double den = 100;
            Fraction res = new Fraction(fraction1.Num * (int)den + fraction1.Den*(int)num, fraction1.Den*(int)(den));
            return res;
        }

        public static Fraction operator -(Fraction fraction1, int value)
        {
            Fraction res = new Fraction(fraction1.Num - fraction1.Den * value, fraction1.Den);
            return res;
        }

        public static Fraction operator -(int value, Fraction fraction1)
        {
            Fraction res = new Fraction(fraction1.Den * value - fraction1.Num, fraction1.Den);
            return res;
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction res = new Fraction(fraction1.Num * fraction2.Num,
                fraction1.Den * fraction2.Den);
            return res;
        }

        public static Fraction operator *(Fraction fraction1, int value)
        {
            Fraction res = new Fraction(fraction1.Num * fraction1.Den*value,
                fraction1.Den * fraction1.Den);
            return res;
        }

        public static Fraction operator *(int value, Fraction fraction1)
        {
            Fraction res = new Fraction(fraction1.Num * fraction1.Den * value,
                fraction1.Den * fraction1.Den);
            return res;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            Fraction res = new Fraction(fraction1.Num * fraction2.Den,
                fraction1.Den * fraction2.Num);
            return res;
        }


        public void Run()
        {

        }
    }
}
