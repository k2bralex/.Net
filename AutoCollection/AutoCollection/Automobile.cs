using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCollection
{
    //производители авто
    enum Vendor
    {
        Audi, WV, Opel, Mersedes
    }

    //типы двигателей
    enum PowerType
    {
        Diesel, Electrical, Gas
    }

    //цвет машины
    enum Color
    {
        White, Black, Red, Green, Blue
    }

    //создаем авто рандомным выбором параметров в конструкторе
    //добавляем метод вывода на экран
    class Automobile
    {
        public Vendor Vendor { get; set; }
        public PowerType PowerType { get; set; }
        public int Power { get; set; }
        public double Volume { get; set; }
        public List<Color> colors { get; set; }

        public Automobile()
        {
            Random rnd = new Random();
            Vendor = (Vendor)rnd.Next(4);
            PowerType = (PowerType)rnd.Next(3);
            Power = rnd.Next(100, 250);
            Volume = (double)(rnd.Next(15, 35)) / 10;
            colors = new List<Color>(rnd.Next(1, 3));
            int capacity = colors.Capacity;
            for (int i = 0; i < capacity; i++)
            {
                colors.Add((Color)rnd.Next(1, 5));
            }
        }

        public string ColorShow()
        {
            string result = "";
            foreach (var color in colors)
            {
                result += color + " ";
            }

            return result;
        }

        public override string ToString()
        {
            return $"Vendor {Vendor} | PowerType {PowerType} | Power {Power} | Volume {Volume} | Color {ColorShow()}";
        }
    }
}
