using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    // Место, куда будем загружать 
    delegate void DoWork();

    // решать как запускать работу
    interface IWorker
    {
        DoWork doWork { get; set; }
        void runWork();
    }

    //класс
    class Worker : IWorker
    {
        public DoWork doWork { get; set; }
        public void runWork()
        {
            if (doWork == null)
            {
                Console.WriteLine($"Я бездельник");
                return;
            }

            doWork();
        }
    }

    class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public Team()
        {
            Worker Fundament = new Worker();
            Fundament.doWork = () => { Console.WriteLine("Я делаю фундамент"); };
            workers.Add(Fundament);

            Worker p = new Worker();
            p.doWork = TakRabotaetPlitochnik;
            workers.Add(p);

            Worker s = new Worker();
            s.doWork = new DoWork(() => { Console.WriteLine("Я сантехник"); });
            workers.Add(s);

            Worker petrovich = new Worker();
            petrovich.doWork += () => { Console.WriteLine("Я петрович"); };
            petrovich.doWork += TakRabotaetPlitochnik;
            petrovich.doWork += (new DoWork((() => { Console.WriteLine("И в сантехнике я шарю");})));

            petrovich.runWork();
        }

        private void TakRabotaetPlitochnik()
        {
            Console.WriteLine("Я кладу плитку");
        }

        public void Run()
        {
            foreach (var w in workers)
            {
                w.runWork();
            }
        }

    }

}
