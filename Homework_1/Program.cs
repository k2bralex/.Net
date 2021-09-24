using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.
            //    Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
            //    Программа должна сосчитать количество введенных пользователем пробелов.

            //Console.WriteLine($"\nYou entered 'spase': "+ spaseCount()+" times");
            //Console.ReadLine();



            //Задание 2.
            //    Ввести с клавиатуры номер трамвайного билета(6 - значное число) и проверить является
            //    ли данный билет счастливым(если на билете напечатано шестизначное число, и сумма первых 
            //    трёх цифр равна сумме последних трёх, то этот билет считается счастливым).

            //Console.Write("Enter ticket number: ");
            //luckyTicket();
            //Console.ReadLine();


            //Задание 3.
            //    Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего 
            //    регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры 
            //    и конвертирует Домашнее задание №1 все символы нижнего регистра в символы верхнего регистра и наоборот.


            //UpperLowerCase();
            //Console.ReadLine();


            //Задание 4.
            //    Даны целые положительные числа A и B(A < B).Вывести все целые числа от A до B включительно;
            //    каждое число должно выводиться на новой строке; при этом каждое число должно выводиться 
            //    количество раз, равное его значению.Например: если А = 3, а В = 7, то программа
            //    должна сформировать в консоли следующий вывод:
            //    3 3 3
            //    4 4 4 4
            //    5 5 5 5 5
            //    6 6 6 6 6 6
            //    7 7 7 7 7 7 7

            //int a = 3, b = 7;
            //int size = b-a+1;
            //int[][] myArrInts = new int[size][];
            //for (int i = 0; i < myArrInts.Length; i++)
            //{
            //    myArrInts[i] = new int[a + i + 1];
            //}

            //for (int i = 0; i < myArrInts.Length; i++)
            //{
            //    for (int j = 0; j < myArrInts[i].Length; j++)
            //    {
            //        myArrInts[i][j] = a + i;
            //        Console.Write(myArrInts[i][j] + " ");
            //    }
            //    Console.WriteLine('\n');
            //}


            //Задание 5.
            //    Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. Например, если было
            //    введено число 345, то программа должна вывести число 543.

            //string num1 = Console.ReadLine();
            //Console.WriteLine(ReverseString(num1));

            //string ReverseString(string s)
            //{
            //    char[] arr = s.ToCharArray();
            //    Array.Reverse(arr);
            //    return new string(arr);
            //}




            Console.ReadLine();


        }

        static int spaseCount()
        {
            ConsoleKeyInfo cki;
            char symbol;
            int count = default;
            Console.Write("Enter char line: ");
            do
            {
                cki = Console.ReadKey();
                symbol = cki.KeyChar;
                if (symbol.Equals(' '))
                {
                    count++;
                }

            } while (symbol != '.');

            return count;
        }

        static void luckyTicket()
        {
            int ticketNum;
            int[] ticketArr = new int[6];
            bool parseResult = int.TryParse(Console.ReadLine(), out ticketNum);
            if (parseResult)
            {
                for (int i = 0; i < 6; i++)
                {
                    ticketArr[i] = ticketNum % 10;
                }

                if ((ticketArr[0] + ticketArr[1] + ticketArr[2]) == (ticketArr[3] + ticketArr[4] + ticketArr[5]))
                {
                    Console.WriteLine("\nNumber is Lucky");
                }
                else
                {
                    Console.WriteLine("\nNumber is Non-Lucky");
                }
            }
            else
            {
                Console.WriteLine($"Incorrect data entered. Exit");
                return;
            }
        }

        static void UpperLowerCase()
        {
            ConsoleKeyInfo cki;
            char symbol;
            char[] newCharLine = new char[80];
            Console.Write("Enter char line: ");
            int j = 0;
            do
            {
                cki = Console.ReadKey();
                symbol = cki.KeyChar;
                newCharLine[j] = symbol;
                j++;
            } while (symbol != '.');

            Console.WriteLine($"\n You entered: ");
            foreach (var ch in newCharLine)
            {
                Console.Write(ch);
            }

            for (int i = 0; i < newCharLine.Length; i++)
            {
                if ((int)newCharLine[i] <= 65 || (int)newCharLine[i] <= 90)
                {
                    int tempNum = newCharLine[i];
                    tempNum += 32;
                    newCharLine[i] = (char)tempNum;
                }
                else
                {
                    int tempNum = newCharLine[i];
                    tempNum -= 32;
                    newCharLine[i] = (char)tempNum;
                }
            }

            Console.WriteLine($"\n REDO: ");
            foreach (var ch in newCharLine)
            {
                Console.Write(ch);
            }
        }
    }
}

