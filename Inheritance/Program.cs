using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SalsePerson sale1 = new SalsePerson(100,"Joe",25,31);
            sale1.ToString();

            Console.ReadLine();

        }
    }
}
