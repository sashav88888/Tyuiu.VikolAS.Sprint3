using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task2.V26.Lib
{
    public class DataService : ISprint3Task2V26
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;

            do
            {
                p *= (Math.Pow(value, 3) * i + 2);
                i++;
            }
            while (i <= stopValue);

            return Math.Round(p, 6);
        }
    }
}
