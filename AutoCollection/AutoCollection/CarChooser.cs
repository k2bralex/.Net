using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCollection
{
    //класс создатель коллекции и поисковик по ней
    class CarChooser
    {
        //создаем коллекцию из 20 рандомных машин
        private List<Automobile> carList = new List<Automobile>(20);

        public CarChooser()
        {
            for (int i = 0; i < carList.Capacity; i++)
            {
                carList.Add(new Automobile());
                //прописана "пауза более рандомной рандомизации" полей в новых машинах
                Console.ReadKey();
            }
        }

        //все методы реализованы с применение try...catch для вывода сообщения о не найденном параметре
        //и продолжения аботы программе без аварийного завершения в случае null значения в var result
        #region ---------SERACHES METHODS------------

        //поиск по цвету
        public void FindByColor(string colorSearch)
        {
            try
            {
                var result = carList.Where(car =>
                    car.colors.Contains((Color)Enum.Parse(typeof(Color), colorSearch, true)));

                foreach (var car in result)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found");
            }
        }

        //поиск по производителю
        public void FindByVendor(string vendorSearch)
        {
            try
            {
                var result = carList.Where(car =>
                    car.Vendor.Equals((Vendor)Enum.Parse(typeof(Vendor), vendorSearch, true)));

                foreach (var car in result)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found");
            }
        }

        //поиск по мощности
        public void FindByPower(string powerSearch)
        {
            try
            {
                var result = carList.Where(car =>
                    car.Power.Equals(int.Parse(powerSearch)));

                foreach (var car in result)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found");
            }

        }


        //поиск по типу двигателя
        public void FindPowerType(string powerTypeSearch)
        {
            try
            {
                var result = carList.Where(car =>
                    car.PowerType.Equals((PowerType)Enum.Parse(typeof(PowerType), powerTypeSearch, true)));
                foreach (var car in result)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found");
            }
        }

        //поиск по мощности
        public void FindVolume(string volumeSearch)
        {
            try
            {
                var result = carList.Where(car =>
                    car.Volume.Equals(double.Parse(volumeSearch)));

                foreach (var car in result)
                {
                    Console.WriteLine(car.ToString());
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Value not found");
            }

        }

        #endregion


        public void Show()
        {
            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public void RunSearch(string value)
        {
            Show();
            Console.WriteLine();
            FindByColor(value);
        }


    }
}
