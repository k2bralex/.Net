using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[2];
            double[,] B = new double[3, 4];

            for (int i = 0; i < A.Length; i++)
            {
                double item;
                double.TryParse(Console.ReadLine(), out item);
                A[i] = item;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Random rnd = new Random();
                    B[i,j] = (double)rnd.Next(1000)/100;
                }
            }

            foreach (var item in A)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in B)
            {
                Console.WriteLine(item.ToString());
            }




            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
