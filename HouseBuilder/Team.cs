using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    //интерфейс для бриагды
    interface IWorker
    {
        void DoWork(object housePart);    
    }

    //реализация интерфеса классом - РАБОЧИЙ
    class Worker : IWorker
    {
        public void DoWork(object housePart)
        {
            if (housePart is Roof)
            {
                Console.WriteLine($"\n{(housePart as Roof).ToString()}. Worker good!");
            }
            if (housePart is Window)
            {
                Console.WriteLine($"\n{(housePart as Window).ToString()}. Worker good!");
            }
            if (housePart is Door)
            {
                Console.WriteLine($"\n{(housePart as Door).ToString()}. Worker good!");
            }
            if (housePart is Wall)
            {
                Console.WriteLine($"\n{(housePart as Wall).ToString()}. Worker good!");
            }
            if (housePart is Basement)
            {
                Console.WriteLine($"\n{(housePart as Basement).ToString()}. Worker good!");
            }


        }
    }

    //реализация интерфеса классом - ТИМЛИДЕР
    class TeamLeader : IWorker
    {
        public void DoWork(object housePart)
        {
            Console.WriteLine($"  Already builded: ");
            if (housePart is House)
            {
                (housePart as House).Show();
            }
        }
    }

}
