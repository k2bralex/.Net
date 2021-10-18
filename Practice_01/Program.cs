using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practice_01
{
    class Program
    {
        delegate double Operation();

        static void Main(string[] args)
        {
            //double[] A = new double[2];
            //double[,] B = new double[3, 4];

            //Operation operation;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    double item;
            //    double.TryParse(Console.ReadLine(), out item);
            //    A[i] = item;
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Random rnd = new Random();
            //        B[i,j] = (double)rnd.Next(1000)/100;
            //    }
            //}

            //foreach (var item in A)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write( B[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////sum all
            //double sum = A.Sum();
            //foreach (var i in B)
            //{
            //    sum += i;
            //}

            //Console.WriteLine("Summary: "+sum);

            //Array.Sort(A);

            //for (int i = 0; i < A.Length; i++)
            //{
            //    double max, min;
            //    max = A[A.Length - i - 1];
            //    min = A[i];
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 4; k++)
            //        {
            //            if (B[j, k] == max)
            //            {
            //                Console.WriteLine($"Max value: {max}");
            //            }
            //            if (B[j, k] == min)
            //            {
            //                Console.WriteLine($"Min value: {min}");
            //            }
            //        }
            //    }
            //}

            //        Random r = new Random();

            //        int[,] A = new int[3,3];

            //        int[,] B = new int[3, 5];

            //        for (int i = 0; i < A.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < A.GetLength(1); j++)
            //            {
            //                A[i, j] = r.Next(5);
            //            }
            //        }

            //        for (int i = 0; i < B.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < B.GetLength(1); j++)
            //            {
            //                B[i, j] = r.Next(5);
            //            }
            //        }

            //        for (int i = 0; i < A.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < A.GetLength(1); j++)
            //            {
            //                Write(A[i, j] + " "); 
            //            }
            //            WriteLine();
            //        }
            //        WriteLine();
            //        for (int i = 0; i < B.GetLength(0); i++)
            //        {
            //            for (int j = 0; j < B.GetLength(1); j++)
            //            {
            //                Write(B[i, j] + " ");
            //            }
            //            WriteLine();
            //        }


            //        int[] result = new int[1];

            //        foreach (var i in A)
            //        {
            //            foreach (var j in B)
            //            {
            //                if (i == j)
            //                {
            //                    int a = i;
            //                    result[result.Length - 1] = a;
            //                    Array.Resize(ref result,result.Length+1);
            //                }
            //            }
            //        }

            //        WriteLine("\n====================\n");

            //        foreach (var i in result)
            //        {
            //            Write(i + " ");
            //        }

            //        WriteLine("\n====================\n");
            //        result = result.Distinct().ToArray();
            //        foreach (var i in result)
            //        {
            //            Write(i + " ");
            //        }



            //string str1 = "annabel", str2 = "abba", result;
            //bool isPolindrom;
            //result = new string(str1.ToCharArray().Reverse().ToArray());
            //isPolindrom = (result == str1);
            //WriteLine(isPolindrom);
            //result = new string(str2.ToCharArray().Reverse().ToArray());
            //isPolindrom = (result == str2);
            //WriteLine(isPolindrom);


            //string input = ReadLine();
            //string[] newArr = input.Split(' ');
            //int count = 0;
            //foreach (var word in newArr)
            //{
            //    count++;
            //}
            //WriteLine(count);
                                                                   


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = r.Next(-100, 100);
            //    }
            //}


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Write(arr[i, j]+"\t");
            //    }
            //    WriteLine();
            //}

            //int maxValue = -100;
            //int minValue = 100;


            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        if (maxValue < arr[i, j])
            //        {
            //            maxValue = arr[i, j];

            //        }

            //        if (minValue > arr[i, j])
            //        {
            //            minValue = arr[i, j];
            //        }
            //    }
            //}

            //foreach (var i in arr)
            //{
            //    if (maxValue < i)
            //    {
            //        maxValue = i;
            //    }
            //    if (minValue > i)
            //    {
            //        minValue = i;
            //    }
            //}
            //WriteLine(minValue+"\t"+maxValue);


            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
