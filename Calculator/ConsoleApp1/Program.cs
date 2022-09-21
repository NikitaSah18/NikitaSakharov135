using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalc 
{
    class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        bool flag = false;

        float first = 0;
        float second = 0;

        char operation = '\0';

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine(" + : сложение чисел");
        Console.WriteLine(" - : вычетание чисел");
        Console.WriteLine(" * : умножение чисел");
        Console.WriteLine(" / : деление чисел");
        Console.WriteLine(" q : ВЫХОД из программы ");
        Console.WriteLine();


        Console.ForegroundColor = ConsoleColor.Green;
        do
        {
            try
            {
                Console.Write("Введите первое число: ");
                first = float.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                second = float.Parse(Console.ReadLine());

                Console.Write("Укажите операцию: ");

                operation = char.Parse(Console.ReadLine());
            }
            catch
            {
                flag = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\aВНИМАТЕЛЬНО ЧИТАЙТЕ ИНСТРУКЦИЮ!!!");
                Console.ForegroundColor = ConsoleColor.Green;
            }


            if (!flag)
            {
                switch (operation)
                {
                    case '+': Console.WriteLine("Сумма чисел составляет: " + (first + second)); break;
                    case '-': Console.WriteLine("Разность чисел состовляет: " + (first - second)); break;
                    case '*': Console.WriteLine("Произведение чисел составляет: " + (first * second)); break;
                    case '/': Console.WriteLine("Отношение чисел составляет: " + (first / second)); break;
                    case 'q': quit = true; break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\aВНИМАТЕЛЬНО ЧИТАЙТЕ ИНСТРУКЦИЮ!!!");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        break;
                }
            }

            flag = false;

        }
        while (!quit);

    }
}
}
