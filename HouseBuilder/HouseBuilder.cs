using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    //класс "строитель" дома
    class HouseBuilder
    {
        //создаем новый экземпляр класс дом
        private House newHouse = new House();

        //метод по выбору следующей части дома в зависимости от уже построенной
        public void PartCreater()
        {
            int count = newHouse.NewHouseList.Count;
            switch (count)
            {
                case 0:
                    newHouse.Setter(new Basement());
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        newHouse.Setter(new Wall());
                    }
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    {
                        newHouse.Setter(new Window());
                    }
                    break;
                case 9:
                    newHouse.Setter(new Door());
                    break;
                case 10:
                    newHouse.Setter(new Roof());
                    break;
            }
        }

        //метод "строитель" дома
        public void Builder()
        {
            //инициализируем новую переменную типа IPart
            //все части дома реализоввают этот интерфейс
            IPart lastPart = null;
            while (!(lastPart is Roof))
            {
                //меню
                Console.WriteLine("\n=========================");
                Console.WriteLine(" Choose the action:\n    1.Worker build part" +
                                  "\n    2.TeamLeader get report");
                Console.WriteLine("=========================\n");
                string choise = Console.ReadLine();

                //перебираем в зависимости от выбора
                switch (choise)
                {
                    //строим следующую чатсь дома
                    case "1":
                        {
                            PartCreater();
                            IWorker newWorker = new Worker();
                            newWorker.DoWork(newHouse.NewHouseList.Last());
                        }
                        break;

                    //выводим отчет о построенном на экран
                    case "2":
                        {
                            if (lastPart != null)
                            {
                                IWorker newWorker = new TeamLeader();
                                newWorker.DoWork(newHouse);
                            }
                            else
                            {
                                Console.WriteLine($"\tNothing was builded yet!!!");
                                continue;
                            }

                        }
                        break;
                }

                lastPart = newHouse.NewHouseList.Last();

            }

            Console.WriteLine("\n==========================" +
                              "HOUSE COMPLITELLY BUILDED" +
                              "==========================\n");
            newHouse.Show();
        }

        public void Run()
        {
            Builder();
        }


    }
}
