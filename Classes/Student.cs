using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        private string _firstName;
        private string _secondName;
        private string _group;
        private int _age;
        private int[][] _grades;

        public Student()
        {
            _firstName = "John";
            _secondName = "Smith";
            _group = "PV011";
            _age = 20;
            _grades = new int[3][];
            gradesCreate();
        }

        public Student(string fn, string sn, string gr, int age):this()
        {
            _firstName = fn;
            _secondName = sn;
            _group = gr;
            _age = age;
        }

        public void gradesCreate()
        {
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                _grades[i] = new int[rnd.Next(10, 15)];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < _grades[i].Length; j++)
                {
                    _grades[i][j] = rnd.Next(5, 12);
                }
            }
        }


        public void getGrade(out int grade)
        {
            gradesPrint();
            Console.WriteLine($"\n\nChoose subject:\n1 - Programming\n2 - Administrating\n3 - Disigning");
            string ch1 = Console.ReadLine();
            Console.Write($"\nChoose grades you need: ");
            int index;
            grade = 0;
            int.TryParse(Console.ReadLine(), out index);
            switch (ch1)
            {
                case "1":
                    grade = _grades[0][--index];
                    break;
                case "2":
                    grade = _grades[1][--index];
                    break;
                case "3":
                    grade = _grades[2][--index];
                    break;
            }

        }

        public void gradesPrint()
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.Write("Programming: ");
                        break;
                    case 1:
                        Console.Write("Administrating: ");
                        break;
                    case 2:
                        Console.Write("Disigning: ");
                        break;
                }

                for (int j = 0; j < _grades[i].Length; j++)
                {
                    Console.Write(_grades[i][j] + " ");
                }
                Console.WriteLine("\n");
            }
        }

        public void Print()
        {
            Console.WriteLine($"STUDENT CARD\n======================\n FirstName: {_firstName}\n " +
                              $"SecondName: {_secondName}\n Group: {_group}\n Age: {_age}");
            Console.WriteLine($"\n======================\n");
            gradesPrint();
        }




    }
}
