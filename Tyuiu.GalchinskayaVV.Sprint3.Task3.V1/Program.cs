using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task3.V1.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл foreach                                                      *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach посчитать количество букв 'a'                    *");
            Console.WriteLine("* в строке: have a nice time                                              *");
            Console.WriteLine("***************************************************************************");

            string str = "have a nice time";
            char ch = 'a';

            DataService ds = new DataService();
            int count = ds.GetCharCount(str, ch);

            Console.WriteLine("Строка: " + str);
            Console.WriteLine("Символ: " + ch);
            Console.WriteLine("Количество: " + count);

            Console.ReadKey();
        }
    }
}
