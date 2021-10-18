using System;
using static System.Console;

namespace Tamagochi
{
    delegate Character LifeCreator();
    class View
    {
        public static LifeCreator creator;
        public static void MainMenu()
        {
            WriteLine("Main menu: ");

            WriteLine("C - Create New Character");
            WriteLine("R - Read Info");
            WriteLine("D - Delete Character");

            WriteLine("User choise: ");
        }

        public static void MainMenuRun()
        {
            ConsoleKey key;
            do
            {
                MainMenu();
                key = ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.C:
                        creator = new LifeCreator(Lifeline.Create);

                        break;

                    case ConsoleKey.R:
                        creator = 
                        break;
                    case ConsoleKey.D:

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


    }
}
