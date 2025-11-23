using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task0.V11.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл for                                                          *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить сумму ряда при n = 5                                          *");
            Console.WriteLine("***************************************************************************");

            int n = 5;
            int start = 1;
            int stop = 10;

            DataService ds = new DataService();
            double result = ds.GetSumSeries(n, start, stop);

            Console.WriteLine("S = " + result);
            Console.ReadKey();
        }
    }
}
