using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBuilder townHouse = new HouseBuilder();
            townHouse.Run();

            Console.ReadKey();
        }
    }
}
