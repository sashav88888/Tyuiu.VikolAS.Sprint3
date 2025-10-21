using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break; // прерываем цикл при x = 0
                }

                double y = Math.Sin(x) / x;
                sum += y;
            }

            return Math.Round(sum, 3); // округляем до 3 знаков после запятой
        }
    }
}
