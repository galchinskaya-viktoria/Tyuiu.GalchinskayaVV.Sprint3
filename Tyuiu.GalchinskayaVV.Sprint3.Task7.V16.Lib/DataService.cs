using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = x - 0.4;
                double y;

                if (denom == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Cos(x) / denom + Math.Sin(x) * 8 * x + 2;
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
