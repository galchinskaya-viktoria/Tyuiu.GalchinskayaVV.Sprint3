using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task2.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task2.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл do...while                                                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда при a = 0,5                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.5;
            int start = 1;
            int stop = 20;

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, start, stop);

            Console.WriteLine("S = " + result);
            Console.ReadKey();
        }
    }
}
