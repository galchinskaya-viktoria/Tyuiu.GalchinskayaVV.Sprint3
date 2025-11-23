using System;
using Tyuiu.GalchinskayaVV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Гальчинская Виктория Владимировна | ПКТб-25-1                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Табулировать F(x) = cos(x)/(x-0,4) + sin(x)*8x + 2 на [-5;5] с шагом 1  *");
            Console.WriteLine("* Значения занести в массив, деление на ноль дать 0, округление до 0.01  *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            DataService ds = new DataService();
            double[] values = ds.GetMassFunction(start, stop);

            Console.WriteLine("   x\tF(x)");
            Console.WriteLine("***************************************************************************");

            int index = 0;
            for (int x = start; x <= stop; x++)
            {
                Console.WriteLine($"{x,4}\t{values[index]}");
                index++;
            }

            Console.ReadKey();
        }
    }
}
