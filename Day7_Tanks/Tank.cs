//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day7_Tanks
//{
//    enum WinVersion
//    {
//        T34Win, PanteraWin, Pat
//    }

//    class Tank
//    {
//        public string _tankName;
//        public int _shell;
//        public int _armor;
//        public int _mobility;
//        public int _damage;

//        public Tank()
//        {
//        }

//        public Tank(string tankName)
//        {
//            Random r = new Random();
//            _tankName = tankName;
//            if (tankName == "T34")
//            {
//                _shell = r.Next(90, 100);
//                _armor = r.Next(450, 500);
//                _mobility = r.Next(90, 100);
//                _damage = r.Next(50, 100);
//            }

//            if (tankName == "Pantera")
//            {
//                _shell = r.Next(120, 150);
//                _armor = r.Next(550, 600);
//                _mobility = r.Next(70, 80);
//                _damage = r.Next(80, 120);
//            }
 
//        }

//        public void Damage(int damage)
//        {
//            _armor -= damage;
//            _mobility -= (int)(damage * 0.2);
//        }
//        public string ShowDamage()
//        {
//            return $"[{DateTime.Now}] {_tankName} fired with";
//        }
//        public string ShowInfo()
//        {
//            return $"|{_tankName} | Ammunition: {_shell} | Armor: {_armor} | Mobility: {_mobility} |";
//        }

//        public static Tank operator /(Tank T34, Tank pantera)
//        {
//            bool res = true;
//            do
//            {
//                //считаем урон противнику
//                T34.Damage(pantera._damage);
//                pantera.Damage(T34._damage);

//                //выводим результат на консоль
//                Console.WriteLine("\n" + T34.ShowDamage() + T34.ShowInfo());
//                Console.WriteLine(pantera.ShowInfo());
//                Console.WriteLine(pantera.ShowDamage() + pantera.ShowInfo());
//                Console.WriteLine(T34.ShowInfo());

//                //пробрасываем исключение
//                if
//                (
//                    T34._armor <= 0 ||
//                    T34._mobility <= 0 ||
//                    T34._shell <= 0
//                )
//                {
//                    res = false;
//                    return pantera;
//                }

//                if
//                (
//                    pantera._armor <= 0 ||
//                    pantera._mobility <= 0 ||
//                    pantera._shell <= 0)
//                {
//                    res = false;
//                    return T34;
//                }

//                if
//                (
//                    ((T34._armor == 0) && (pantera._armor == 0)) ||
//                    ((T34._mobility == 0) && (pantera._mobility == 0)) ||
//                    ((T34._shell == 0) && (pantera._shell == 0)))
//                {
//                    res = false;
//                    return T34;
//                }

//            } while (res);

//        }

//        public void Fight()
//        {
//            List<Tank> T34List = null;
//            List<Tank> panteraList = null;
//            for (int i = 0; i < 5; i++)
//            {
//                T34List.Add(new Tank("T34"));
//                panteraList.Add(new Tank("Pantera"));
//            }
//        }

//        public void Run()
//        {
//            Fight();
//        }
//    }
//}
