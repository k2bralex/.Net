using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Tanks
{
    //создаем перечисление победителей
    enum WinVersion
    {
        T34Win, PanteraWin, Pat
    }

    class Tank
    {
        //объявляем поля класса
        public string _tankName;
        public int _shell;
        public int _armor;
        public int _mobility;
        public int _damage;

        //счетчики побед в раундах
        public static int _t34Count = 0;
        public static int _panteraCount = 0;

        public Tank(){}

        //в зависимости от переданной строки создаем танк
        public Tank(string tankName)
        {
            Random r = new Random();
            _tankName = tankName;
            if (tankName == "T34")
            {
                _shell = r.Next(90, 100);
                _armor = r.Next(450, 500);
                _mobility = r.Next(90, 100);
                _damage = r.Next(80, 100);
            }

            if (tankName == "Pantera")
            {
                _shell = r.Next(120, 150);
                _armor = r.Next(550, 600);
                _mobility = r.Next(70, 80);
                _damage = r.Next(80, 120);
            }

        }

        //наносим урон
        public void Damage(int damage)
        {
            _armor -= damage;
            _mobility -= (int)(damage * 0.2);
        }
        //показываем урон
        public string ShowDamage()
        {
            return $"[{DateTime.Now}] {_tankName} fired with";
        }
        //показываем инфо по объекту
        public string ShowInfo()
        {
            return $"|{_tankName} | Ammunition: {_shell} | Armor: {_armor} | Mobility: {_mobility} |";
        }

        //боевка
        public static WinVersion DoFight(Tank T34, Tank pantera)
        {
            do
            {
                //считаем урон противнику
                T34.Damage(pantera._damage);
                pantera.Damage(T34._damage);

                //выводим результат на консоль
                Console.WriteLine("\n" + T34.ShowDamage() + T34.ShowInfo());
                Console.WriteLine(pantera.ShowInfo());
                Console.WriteLine(pantera.ShowDamage() + pantera.ShowInfo());
                Console.WriteLine(T34.ShowInfo());

                //выбираем победителя
                if
                (
                    T34._armor <= 0 ||
                    T34._mobility <= 0 ||
                    T34._shell <= 0
                )
                {
                    return WinVersion.PanteraWin;
                }

                if
                (
                    pantera._armor <= 0 ||
                    pantera._mobility <= 0 ||
                    pantera._shell <= 0)
                {
                    return WinVersion.T34Win;
                }

                if
                (
                    ((T34._armor == 0) && (pantera._armor == 0)) ||
                    ((T34._mobility == 0) && (pantera._mobility == 0)) ||
                    ((T34._shell == 0) && (pantera._shell == 0)))
                {
                    return WinVersion.Pat;
                }

            } while (true);
        }

        //выводим инфо о обедителе + считаем победы по раунду
        public static void WhoWinner(WinVersion winner)
        {

            switch (winner)
            {
                case (WinVersion)0:
                    Console.WriteLine($"\n\n========================\nT34's team WIN in this rounds" +
                                      $"\n========================\n");
                    Console.WriteLine("Press any key to continue");
                    _t34Count++;
                    break;
                case (WinVersion)1:
                    Console.WriteLine($"\n\n========================\nPantera's team WIN in this rounds" +
                                      $"\n========================\n");
                    Console.WriteLine("Press any key to continue");
                    _panteraCount++;
                    break;
                case (WinVersion)2:
                    Console.WriteLine($"\n\n========================\n\t!!!DRAW!!!" +
                                      $"\n========================\n");
                    Console.WriteLine("Press any key to continue");
                    _panteraCount++;
                    _t34Count++;
                    break;
            }

            Console.WriteLine($"\tFINAL SCORE\n T34 team: {_t34Count} : " +
                              $"{_panteraCount} Pantera's team");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        //выбираем финального победителя
        public bool FinalCount()
        {
            return _panteraCount < _t34Count;
        }

        //создаем листы с танками для боевки, итерационно запускаем метод боя и
        //выводим финальный результат по раундам
        public void Fight()
        {
            List<Tank> T34List = new List<Tank>();
            List<Tank> panteraList = new List<Tank>();
            for (int i = 0; i < 5; i++)
            {
                T34List.Add(new Tank("T34"));
                panteraList.Add(new Tank("Pantera"));

                Console.WriteLine($"Created pair: {(T34List[i].ShowInfo())}\t{panteraList[i].ShowInfo()}");

                WhoWinner(DoFight(T34List[i], panteraList[i]));
            }

            Console.WriteLine($"!!!{(FinalCount() ? "T34" : "PANTERA")} WINNNER!!!");
        }

        public void Run()
        {
            Fight();
        }
    }
}
