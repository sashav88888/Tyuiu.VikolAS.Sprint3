using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] results = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double cosX = Math.Cos(x);

                // Проверка на деление на ноль
                double fx = (cosX != 0) ? (2 * x - 3) / cosX - 2 * x + 5 * x - Math.Sin(x) : 0;

                results[i] = Math.Round(fx, 2);
            }

            return results;
        }
    }
}
