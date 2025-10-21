using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task5.V24.Lib
{
    public class DataService : ISprint3Task5V24
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0.0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += (Math.Pow(x, k) + 2) * Math.Sin(k);
                }
            }

            return sum;
        }
    }
}
