using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urok_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite newShaComposite = new Composite();
            newShaComposite.Run();

            Console.WriteLine("\n\nPress");
            Console.ReadKey();
        }
    }
}
