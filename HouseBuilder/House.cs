using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder
{
    //создаем интерфейс
    interface IPart
    {
        void HousePart();
    }

    //класс хаус содержит в себе Лист частей и которых состоит дом
    //методы и свойства для доступа к ним из билдера
    class House
    {
        private List<IPart> newHouseList = new List<IPart>();

        public List<IPart> NewHouseList
        {
            get => newHouseList;
        }

        public IPart Getter()
        {
            return newHouseList.First();
        }

        public void Setter(IPart part)
        {
            newHouseList.Add(part);
        }

        public House()
        {

        }

        public void Show()
        {
            foreach (var part in newHouseList)
            {
                Console.WriteLine("  -->" + part.ToString());
            }
        }

    }

 

    #region --------------IPART CLASSES--------------

    class Wall : IPart
    {
        public string Name { get; set; }

        public override string ToString()
        {
            HousePart();
            return $"{Name} builded";
        }

        public void HousePart()
        {
            Name = "Wall";
        }
    }

    class Door : IPart
    {
        public string Name { get; set; }

        public override string ToString()
        {
            HousePart();
            return $"{Name} builded";
        }

        public void HousePart()
        {
            Name = "Door";
        }
    }

    class Window : IPart
    {
        public string Name { get; set; }

        public override string ToString()
        {
            HousePart();
            return $"{Name} builded";
        }

        public void HousePart()
        {
            Name = "Window";
        }

    }

    class Basement : IPart
    {
        public string Name { get; set; }

        public override string ToString()
        {
            HousePart();
            return $"{Name} builded";
        }

        public void HousePart()
        {
            Name = "Basement";
            ;
        }
    }

    class Roof : IPart
    {
        public string Name { get; set; }

        public void HousePart()
        {
            Name = "Roof";
            ;
        }

        public override string ToString()
        {
            HousePart();
            return $"{Name} builded";
        }
    }

    #endregion
}