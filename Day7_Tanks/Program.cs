using System;
using System.Collections.Generic;
using MyClassLib;

namespace Day7_Tanks
{
    //Создаем новые классы под наши исключения TankExceptions
    //Три базовых случая:
    //                    - Ничья
    //                    - Пантера победила
    //                    - 3Т34 победил


    class TankFight
    {
        //Счетчики побед в раунде
        private int _t34Count = 0;
        private int _panteraCount = 0;

        //Коллекции объектов
        List<T34> T34List = new List<T34>(5);
        List<Pantera> PanteraList = new List<Pantera>(5);
        
        public void BaseFight()
        {
            //Создание комманд
            CreateTeam();

            //Цикл на 5 боев
            for (int i = 0; i < T34List.Capacity; i++)
            {
                //перехватываем наши исключетиельные случаи
                try
                {
                    //бой до тех пор пока один из танков не выйдет из строя
                    do
                    {
                        //стреляем
                        int panteraDoDamage = DoFire(PanteraList[i]);
                        int T34DoDamage = DoFire(T34List[i]);
                        //считаем урон противнику
                        T34List[i].Damage(panteraDoDamage);
                        PanteraList[i].Damage(T34DoDamage);

                        //выводим результат на консоль
                        Console.WriteLine("\n" + T34List[i].ShowDamage() + ShowFightDetails(T34DoDamage));
                        Console.WriteLine(PanteraList[i].ShowInfo());
                        Console.WriteLine(PanteraList[i].ShowDamage() + ShowFightDetails(panteraDoDamage));
                        Console.WriteLine(T34List[i].ShowInfo());

                        //пробрасываем исключение
                        if 
                        (
                            T34List[i].Armor <= 0 ||
                            T34List[i].Mobility <= 0 ||
                            T34List[i].Shell <= 0
                        )
                        {
                            throw new PanteraWin();
                        }

                        if 
                        (
                            PanteraList[i].Armor <= 0 ||
                            PanteraList[i].Mobility <= 0 ||
                            PanteraList[i].Shell <= 0)
                        {
                            throw new T34Win();
                        }

                        if 
                        (
                            ((T34List[i].Armor == 0) && (PanteraList[i].Armor == 0)) ||
                            ((T34List[i].Mobility == 0) && (PanteraList[i].Mobility == 0)) ||
                            ((T34List[i].Shell == 0) && (PanteraList[i].Shell == 0)))
                        {
                            throw new Pat();
                        }

                    } while (true);
                }
                //ловим исключение
                catch (PanteraWin)
                {
                    Console.WriteLine($"\n\n========================\nPantera's team WIN in this rounds" +
                                      $"\n========================\n");
                    _panteraCount++;
                }
                catch (T34Win)
                {
                    Console.WriteLine($"\n\n========================\nT34's team WIN in this rounds" +
                                      $"\n========================\n");
                    _t34Count++;
                }
                catch (Pat)
                {
                    Console.WriteLine($"\n\n========================\n\t!!!DRAW!!!" +
                                      $"\n========================\n");
                    _panteraCount++;
                    _t34Count++;
                }
                
                Console.WriteLine($"\tFINAL SCORE\n T34 team: {_t34Count} : " +
                                  $"{_panteraCount} Pantera's team");

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();

            }

            Console.WriteLine($"!!!{(FinalCount()?"T34":"PANTERA")} WINNNER!!!");

        }

        public void CreateTeam()
        {
            for (int i = 0; i < T34List.Capacity; i++)
            {
                T34List.Add(new T34());
                                                                    //Console.WriteLine("\nPress any key to continue");
                                                                    //Console.ReadKey();
                PanteraList.Add(new Pantera());
                                                                    //Console.WriteLine("Press any key to continue\n");
                                                                    //Console.ReadKey();
                Console.WriteLine($"Created pair: {GetInfo(T34List[i])}\t{GetInfo(PanteraList[i])}");
            }
        }

        public bool FinalCount()
        {
            return _panteraCount < _t34Count;
        }

        public string ShowFightDetails(int damage)
        {
            return $" {damage} damage.";
        }

        public int DoFire(IWeapon weapon)
        {
            return weapon.Fire();
        }

        public string GetInfo(IHasInfo info)
        {
           return info.ShowInfo();
        }

        public void Run()
        {
            BaseFight();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //TankFight fight = new TankFight();
            //fight.Run();

            Tank tank = new Tank();
            tank.Run();

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
