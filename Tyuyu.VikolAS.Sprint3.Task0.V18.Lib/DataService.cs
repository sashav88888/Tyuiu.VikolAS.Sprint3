using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuyu.VikolAS.Sprint3.Task0.V18.Lib

{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int k = startValue; k <= stopValue; k++)
            {
                p *= Math.Pow(2 / (Math.Cos(value) + 0.5), k);
            }

            return Math.Round(p, 3);
        }
    }
}
