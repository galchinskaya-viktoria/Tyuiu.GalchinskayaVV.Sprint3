using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
