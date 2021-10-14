using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice_03.CopyProject;

namespace Practice_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //RangeOfArray Arr = new RangeOfArray(-10,10);
            //Arr.Fill();
            //Arr.Print();
            //Console.WriteLine(Arr.Value(-5));
            //Console.WriteLine(Arr.Index(5));

            BurningRom newRom = new BurningRom();
            double dataSize = 6000.65;

            Console.WriteLine("\n+++++++++++++++++++++\n");
            newRom.StorageQty(dataSize);
            Console.WriteLine("\n+++++++++++++++++++++\n");
            newRom.TimeToRecord(dataSize);
            Console.WriteLine("\n+++++++++++++++++++++\n");
            Console.WriteLine(newRom.TotalMemoryCalc()); 



            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
