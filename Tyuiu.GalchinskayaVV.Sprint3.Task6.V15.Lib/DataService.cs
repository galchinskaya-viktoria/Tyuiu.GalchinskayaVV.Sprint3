using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task6.V15.Lib
{
    public class DataService : ISprint3Task6V15
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumAll = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                for (int d = 1; d <= n; d++)
                {
                    if (n % d == 0)
                    {
                        sumAll += d;
                    }
                }
            }

            return sumAll;
        }
    }
}
