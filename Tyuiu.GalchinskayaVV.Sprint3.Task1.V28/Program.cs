using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task1.V28.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл while                                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда при a = 0,5                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.5;
            int start = 1;
            int stop = 18;

            DataService ds = new DataService();
            double result = ds.GetSumSeries(a, start, stop);

            Console.WriteLine("S = " + result);
            Console.ReadKey();
        }
    }
}
