using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void DoPublisher();

    class Publish
    {
        private List<string> publishList = new List<string>() {"BMW", "Mersedes", "Audi"};

        DoPublisher doPublisher;

        public void Show()
        {
            doPublisher = Print1;
            doPublisher();
            Console.WriteLine($"\n-----------------------");
            doPublisher = Print2;
            doPublisher();
        }

        public void Print1()
        {
            foreach (var item in publishList)
            {
                Console.Write($"{item}, ");
            }
        }

        public void Print2()
        {
            foreach (var item in publishList)
            {
                Console.Write($"{item}; ");
            }
        }
    }
}
