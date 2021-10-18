using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace Tamagochi
{

    class Lifeline
    {
        private Character character { get; set; }

        public static Character Create()
        {
            WriteLine($"Enter name: ");
            string name = ReadLine();
            WriteLine($"Choose sex: 1- male , 2- female");
            int.TryParse(ReadLine(), out int sex);
            Character newChar = new Character(name, sex);
            return newChar;
        }
        public static string ToString(Character character)
        {
            return character.ToString();
        }
    }
}
