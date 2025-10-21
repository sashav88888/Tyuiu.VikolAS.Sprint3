using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VikolAS.Sprint3.Task0.V18.Lib
{
    // Интерфейс для задания (можно подключить, если нужен)
    public interface ISprint3Task0V18
    {
        double GetMultiplySeries(int value, int startValue, int stopValue);
    }


    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                // Формула произведения ряда
                p *= Math.Pow(2 / (Math.Cos(value) + 0.5), k);
            }

            return Math.Round(p, 3);
        }
    }
}