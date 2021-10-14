using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarConstructor;
using static System.Console;

namespace CarConstructor
{
    //перечисления для выбора произовдтеляб цвета з/ч и т,д,
    #region ------ENUM OF CARPARTS------

    enum Vendor
    {
        Audi, BMW, Mersedes
    }
    enum Color
    {
        Black, White, Silver
    }
    enum Wheels
    {
        Road, OffRoad, Race
    }
    enum EngineType
    {
        Gas, Electrical, Diesel
    }

    #endregion

    class Constructor
    {
        //создается новая машина
        Car newCar = new Car();

        public Constructor()
        {

        }

        //меню
        private void Menu()
        {
            WriteLine("User menu: \n---------------------------\n");
            WriteLine("V - Vendor choose");
            WriteLine("C - Color choose");
            WriteLine("E - Engine type add");
            WriteLine("W - Wheels type add");

            WriteLine("\nP - print car complectation\n");


            WriteLine("User choise: ");
        }

        //выбор пользователя? что добавить ма машину? можно расширять
        //не трогая при этом сам класс машины
        public void Run()
        {
            ConsoleKey key;
            do
            {
                Menu();
                key = ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.V:
                        newCar.carPart = AddVendor;
                        newCar.AddPart();
                        break;

                    case ConsoleKey.C:
                        newCar.carPart = AddColor;
                        newCar.AddPart();
                        break;

                    case ConsoleKey.E:
                        newCar.carPart = AddEngine;
                        newCar.AddPart();
                        break;

                    case ConsoleKey.W:
                        newCar.carPart = AddWheels;
                        newCar.AddPart();
                        break;

                    case ConsoleKey.P:
                        Print();
                        break;


                    case ConsoleKey.Escape:
                        return; break;

                }

                WriteLine("\n--------------------");
                WriteLine("Press any key");
                ReadKey();
                Clear();
            } while (key != ConsoleKey.Escape);

        }

        //методы по добавлению запчастей в машину

        #region -----METHODS------

        string AddEngine()
        {
            WriteLine($"1 - Diesel");
            WriteLine($"2 - Gas");
            WriteLine($"3 - Electrical");
            string engineType = ReadLine();

            switch (engineType)
            {
                case "1": engineType = EngineType.Diesel.ToString(); break;
                case "2": engineType = EngineType.Gas.ToString(); break;
                case "3": engineType = EngineType.Electrical.ToString(); break;
            }

            return engineType;
        }

        string AddVendor()
        {
            WriteLine($"1 - Audi");
            WriteLine($"2 - BMW");
            WriteLine($"3 - Mersedes");
            string vendor = ReadLine();

            switch (vendor)
            {
                case "1": vendor = Vendor.Audi.ToString(); break;
                case "2": vendor = Vendor.BMW.ToString(); break;
                case "3": vendor = Vendor.Mersedes.ToString(); break;
            }

            return vendor;
        }
        string AddColor()
        {
            WriteLine($"1 - Black");
            WriteLine($"2 - White");
            WriteLine($"3 - Silver");
            string color = ReadLine();

            switch (color)
            {
                case "1": color = Color.Black.ToString(); break;
                case "2": color = Color.White.ToString(); break;
                case "3": color = Color.Silver.ToString(); break;
            }

            return color;
        }
        string AddWheels()
        {
            WriteLine($"1 - Road");
            WriteLine($"2 - OffRoad");
            WriteLine($"3 - Race");
            string wheels = ReadLine();

            switch (wheels)
            {
                case "1": wheels = Wheels.Road.ToString(); break;
                case "2": wheels = Wheels.OffRoad.ToString(); break;
                case "3": wheels = Wheels.Race.ToString(); break;
            }

            return wheels;
        }

        //используя интерфейс IEnumerable перебираем элементы в коллекции
        private void EchoResult(IEnumerable<Part> list)
        {
            foreach (var item in list)
            {
                WriteLine(item.Name);
            }
        }

        //выводим коллекцию на экран
        void Print()
        {
            WriteLine("Part list in new car:");
            EchoResult(newCar.ReadAll());
        }

    }

    #endregion

}
