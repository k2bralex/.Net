using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //1.1.Разработать один из классов, в соответствии с полученным вариантом.
            //1.2.Реализовать не менее пяти закрытых полей(различных
            //типов), представляющих основные характеристики
            //    рассматриваемого класса.
            //1.3.Создать не менее трех методов управления классом
            //и методы доступа к его закрытым полям.
            //1.4.Создать метод, в который передаются аргументы
            //по ссылке.
            //1.5.Создать не менее двух статических полей(различных типов), представляющих общие характеристики
            //    объектов данного класса.
            //1.6.Обязательным требованием является реализация нескольких перегруженных конструкторов, аргументы
            //которых определяются студентом, исходя из специфики реализуемого класса, а так же реализация
            //    конструктора по умолчанию.
            //1.7.Создать статический конструктор.
            //1.8.Создать массив(не менее 5 элементов) объектов
            //    созданного класса.
            //1.9.Создать дополнительный метод для данного класса
            //    в другом файле, используя ключевое слово partial.
            //    Варианты(по выбору):

            //2.Мотоцикл;

            Motorcycle moto1 = new Motorcycle(5000,"Windshield_type_1", "FogLights_type_1");
            Motorcycle moto2 = new Motorcycle(6000, "Windshield_type_2", "FogLights_type_2");
            Motorcycle moto3 = new Motorcycle(7000, "Windshield_type_3", "FogLights_type_3");
            Motorcycle moto4 = new Motorcycle(8000, "Windshield_type_4", "FogLights_type_4");
            Motorcycle moto5 = new Motorcycle(9000, "Windshield_type_5", "FogLights_type_5");

            List<Motorcycle> motoArrayList = new List<Motorcycle>();
            motoArrayList.Add(moto1);
            motoArrayList.Add(moto2);
            motoArrayList.Add(moto3);
            motoArrayList.Add(moto4);
            motoArrayList.Add(moto5);

            foreach (var i in motoArrayList)
            {
                i.Print();
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        partial class Motorcycle
        {
            private string name;
            private double price;
            private List<string> additionalComplectationList;
            private static List<string> BaseComplectationList;


            #region ---------Constructors-----------

            static Motorcycle()
            {
                BaseComplectationList = new List<string>();
                BaseComplectationList.Add("2 wheels");
                BaseComplectationList.Add("1 seat");
                BaseComplectationList.Add("1 steering wheel");
            }

            public Motorcycle()
            {
                name = "Honda";
                price = 10000.00;
                additionalComplectationList = new List<string>();
            }

            public Motorcycle(double extraPrice, string additionalOption) : this()
            {
                price += extraPrice;
                additionalComplectationList.Add(additionalOption);
            }
            public Motorcycle(double extraPrice, string additionalOption1, string additionalOption2) : this()
            {
                price += extraPrice;
                additionalComplectationList.Add(additionalOption1);
                additionalComplectationList.Add(additionalOption2);
            }

            public Motorcycle(double extraPrice, string additionalOption1, string additionalOption2, string additionalOption3) : this()
            {
                price += extraPrice;
                additionalComplectationList.Add(additionalOption1);
                additionalComplectationList.Add(additionalOption2);
                additionalComplectationList.Add(additionalOption3);
            }

            #endregion


            public double Price
            {
                get => price;
                set => price = value;
            }
        }

        partial class Motorcycle
        {
            #region ---------Methods-----------


            public void Print()
            {
                Console.WriteLine($"Мотоцикл модели: " + name + "\n price: " + price + "\n  Complectation: ");
                foreach (var i in BaseComplectationList)
                {
                    Console.WriteLine(i);
                }
                foreach (var i in additionalComplectationList)
                {
                    Console.WriteLine(i);
                }
            }

            public double getUAHPrice(double courseUSD)
            {
                return price *= courseUSD;
            }



            #endregion
        }



    }
}
