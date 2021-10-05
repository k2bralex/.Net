﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoCollection
{
    enum Vendor
    {
        Audi, WV, Opel, Mersedes   
    }

    enum PowerType
    {
        Diesel, Electrical, Gas
    }

    enum Color
    {
        White,Black,Red,Green,Blue
    }

    class Automobile
    {
        public Vendor Vendor { get; set; }
        public PowerType PowerType { get; set; }
        public int Power { get; set; }
        public double Volume { get; set; }
        public List<Color> colors;

        public Automobile()
        {
            Random rnd = new Random();
            Vendor = (Vendor) rnd.Next(4);
            PowerType = (PowerType)rnd.Next(3);
            Power = rnd.Next(100,250);
            Volume = (double)(rnd.Next(15, 35)/10);
            colors = new List<Color>(rnd.Next(1, 2));
            int capacity = colors.Capacity;
            for (int i = 0; i < capacity; i++)
            {
                colors.Add((Color)rnd.Next(1, 5));
            }
        }

        public override string ToString()
        {
            return $"Vendor {Vendor} | PowerType {PowerType} | Power {Power} | Vendor {Vendor} | Volume {Volume} |";
        }
    }

    class CarChooser
    {
        private List<Automobile> carList = new List<Automobile>(10);

        public void FindByColor()
        {
            var resColor = carList.Where(car => car.colors.Contains(Color.Red));
        }

        public void RunSearch()
        {
            FindByColor();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            CarChooser newCar = new CarChooser();
            newCar.RunSearch();
            newCar.

            Console.WriteLine("Press");
            Console.ReadKey();
        }
    }
}
