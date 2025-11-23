using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task6.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы и делители                                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Среди целых чисел от 6 до 15 найти сумму всех их делителей              *");
            Console.WriteLine("***************************************************************************");

            int start = 6;
            int stop = 15;

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(start, stop);

            Console.WriteLine("Сумма всех делителей чисел от 6 до 15: " + result);

            Console.ReadKey();
        }
    }
}
