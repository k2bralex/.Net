using System;
using static System.Console;

namespace Tamagochi
{
    enum Sex { Male=1, Female }

    class Character
    {
        private string Name { get; set; }
        private int Age { get; } = 0;

        public int Sex { get; set; }

        public Character(string name, int sex)
        {
            Name = name;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"My name: {Name}, I`m days old: {Age}";
        }
    }
}
