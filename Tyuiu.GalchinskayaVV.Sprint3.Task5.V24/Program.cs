using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task5.V24.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task5.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = sum_{i=1..3} sum_{k=1..12} (x^k + 2) sin(k), при x = 2              *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int stop1 = 3;
            int stop2 = 12;

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
