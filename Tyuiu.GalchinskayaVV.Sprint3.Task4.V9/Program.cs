using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task4.V9.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы и вычисление функций                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке x ∈ [-5; 5] вычислить y = x / (cos(x) - x),                  *");
            Console.WriteLine("* при x = 0 значение пропустить. Полученные значения перемножить.        *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            DataService ds = new DataService();
            double result = ds.Calculate(start, stop);

            Console.WriteLine("Результат произведения: " + result);
            Console.ReadKey();
        }
    }
}
