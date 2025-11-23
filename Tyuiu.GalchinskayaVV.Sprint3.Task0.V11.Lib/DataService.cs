using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task0.V11.Lib
{
    public class DataService : ISprint3Task0V11
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double t = 1.0 / Math.Pow(value, k);
                sum += t * t;
            }

            return Math.Round(sum, 3);
        }
    }
}
