using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VikolAS.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            // Цикл от startValue до stopValue включительно
            for (int k = startValue; k <= stopValue; k++)
            {
                // Вычисляем произведение ряда по формуле p *= (2 / (cos(X) + 0.5))^k
                p *= Math.Pow(2 / (Math.Cos(value) + 0.5), k);
            }

            // Округляем результат до 3 знаков после запятой
            return Math.Round(p, 3);
        }
    }
}
