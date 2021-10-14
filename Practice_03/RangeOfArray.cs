using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practice_03
{
    class NewExpression:Exception { } 
    class RangeOfArray
    {
        private int MinRange { get; set; } = 0;
        private int MaxRange { get; set; } = 10;
        private int[] arr;


        public RangeOfArray() { }
        public RangeOfArray(int minRange, int maxRange)
        {
            MinRange = minRange;
            MaxRange = maxRange;
            int elemsInArr = 0;
            for (int i = minRange; i <= maxRange; i++)
            {
                elemsInArr++;
            }
            arr = new int[elemsInArr];
        }

        public void Fill(int min = 0, int max = 10)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
        }

        public int Index(int num)
        {
            int index = MinRange;
            for (int i = 0; i < arr.Length; i++, index++)
            {
                if (arr[i]==num)
                {
                    break;
                }

            }
            Console.WriteLine("No element found");
            return index;
        }

        public int Value(int index)
        {
            int j = MinRange, value=0;
            for (int i = 0; i < arr.Length; i++,j++)
            {
                if (j==index)
                {
                    value = arr[i]; break;
                }
                
            }
            Console.WriteLine("No element found");
            return value;
        }

        public void Print()
        {
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
