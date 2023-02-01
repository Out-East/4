using System;
using System.Collections.Generic;
namespace practic_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
          
            day1();
        }
        static void day1()
        {
            List<string> one = new List<string> { "  1.Поиграть в кампутар", "  2.Сходить на вечеринку" };
            Console.WriteLine("\tЗаметки 01.02.2020");
            Console.WriteLine(one[0]);
            Console.WriteLine(one[1]);
            string F = "Заметка должна быть выполнена:";

            int position = 1;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo clavisha = Console.ReadKey();

            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 01.02.2020");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                else if (clavisha.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.Clear();
                    Console.WriteLine("\tЗаметки 01.02.2020");
                    Console.WriteLine(one[0]);
                    Console.WriteLine(one[1]);
                }
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();

                if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day2(); }
                else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day3(); }
            }
            if (position == 1)
            {
                Console.Clear();
                Console.WriteLine( " Поиграть в Apex,Dota,Pubg");
                Console.WriteLine();
                Console.WriteLine(F + ": 15.02.2020 - 11:50");
            }
            else if (position == 2)
            {
                Console.Clear();
                Console.WriteLine( " Не умереть, Выжить, Остаться в живых ");
                Console.WriteLine();
                Console.WriteLine(F + ": 15.02.2020 - 10:19");
            }
            Console.ReadKey();
            Console.Clear();
            day1();

            static void day2()
            {

                List<string> two = new List<string> { "  1. Сделать работы", "  2. Зайти в магазин по дороге домой" };

                Console.WriteLine("\tЗаметки 01.02.2020");
                Console.WriteLine(two[0]);
                Console.WriteLine(two[1]);
                string F = "Заметка должна быть выполнена:";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 01.02.2020 ");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                        Console.Clear();
                        Console.WriteLine("\tЗаметки 01.02.2020 ");
                        Console.WriteLine(two[0]);
                        Console.WriteLine(two[1]);
                    }
                    Console.SetCursorPosition(0,position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();
                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); day3(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day1(); }
                }
                if (position == 1)
                {
                    Console.Clear();
                    Console.WriteLine( " Сделать Вышмат, Сделать БЖД");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 15.02.2020 - 00:00");
                }
                else if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine( "Купить чипсеки и попить");
                    Console.WriteLine();
                    Console.WriteLine(F + ": 15.02.2020 - 00:00");
                }
                Console.ReadKey();
                Console.Clear();
                day2();
            }
            static void day3()
            {
                List<string> three = new List<string> { "  1. Досмотреть сериал" };
                Console.WriteLine("\tЗаметки 01.02.2020");
                Console.WriteLine(three[0]);
                string F = "Заметка должна быть выполнена";

                int position = 1;
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                ConsoleKeyInfo clavisha = Console.ReadKey();

                while (clavisha.Key != ConsoleKey.Enter)
                {
                    if (clavisha.Key == ConsoleKey.UpArrow)
                    {                      
                    }
                    else if (clavisha.Key == ConsoleKey.DownArrow)
                    {                   
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    clavisha = Console.ReadKey();

                    if (clavisha.Key == ConsoleKey.RightArrow) { Console.Clear(); Console.WriteLine("Заметок больше нет."); day1(); }
                    else if (clavisha.Key == ConsoleKey.LeftArrow) { Console.Clear(); day2(); }
                }
                Console.Clear();
                Console.WriteLine( "Последний сезон");
                Console.WriteLine();
                Console.WriteLine(F + ": 15.02.2020 - 00:00");

            }
        }

    }
}