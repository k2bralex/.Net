using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyDelegate.Data;
using MyDelegate.Data.Entity;
using static System.Console;

namespace Delegate.View
{
    class Academy
    {
        public Academy()
        {

        }

        private void BigMonitor()
        {
            WriteLine("Something happen - reporting!!!");
        }

        private void SmallMonitor()
        {
            WriteLine("What's happen?");
        }

        private void Menu()
        {
            WriteLine("User menu: ");

            WriteLine("R - Read All");
            WriteLine("N - Find by name");

            WriteLine("S - Enable Small Monitor");
            WriteLine("B - Enable Big Monitor");
            WriteLine("D - Disable Any Monitor");

            WriteLine("L - change name to LOWER CASE");

            WriteLine("User choise: ");
        }

        public void Run()
        {
            ConsoleKey key;
            do
            {
                Menu();
                key = ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.L:
                        DBContext.GetInstance().ChangeAllStudent(s =>
                        {
                            s.Name = s.Name.ToLower();
                            Write("\n" + s.Name + " ");
                            return s;
                        });
                        break;

                    case ConsoleKey.S:
                        DBContext.GetInstance().onAnyRead = SmallMonitor;
                        break;
                    case ConsoleKey.B:
                        DBContext.GetInstance().onAnyRead = BigMonitor;
                        break;
                    case ConsoleKey.D:
                        DBContext.GetInstance().onAnyRead = null;
                        break;


                    case ConsoleKey.Escape:
                        return;break;
                    
                    case ConsoleKey.R: GetAll();
                        break;
                    case ConsoleKey.N: GetByName();
                        break;
                }

                WriteLine("\n--------------------");
                WriteLine("Press any key");
                ReadKey();
                Clear();
            } while (key != ConsoleKey.Escape);

        }

        private void EchoResult(IEnumerable<Student> list)
        {
            foreach (var s in list)
            {
                WriteLine(s);
            }
        }

        void GetByName()
        {
            Write("\nEnter name: ");
            EchoResult(DBContext.GetInstance().FindByName(ReadLine()));
            
        }


        void GetAll()
        {
            WriteLine("\nAll students: ");
            EchoResult(DBContext.GetInstance().ReadAll());


        }
    }
}
