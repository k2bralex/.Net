using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarChooser newCar = new CarChooser();

            newCar.Show();
            
            newCar.FindByColor("Red");
            Console.WriteLine("\n");
            newCar.FindByColor("blue");

            Console.WriteLine("--------------------------------");

            newCar.FindByVendor("WV");
            Console.WriteLine("\n");
            newCar.FindByVendor("opel");

            Console.WriteLine("--------------------------------");

            newCar.FindPowerType("Electrical");
            Console.WriteLine("\n");
            newCar.FindPowerType("diesel");

            Console.WriteLine("--------------------------------");

            newCar.FindVolume("2");
            Console.WriteLine("\n");
            newCar.FindVolume("1.5");
            

            Console.WriteLine("Press");
            Console.ReadKey();
        }
    }
}
