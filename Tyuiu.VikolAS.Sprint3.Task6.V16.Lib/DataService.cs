using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task6.V16.Lib
{
    public class DataService : ISprint3Task6V16
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisors = 0;

            for (int n = startValue; n <= stopValue; n++)
            {
                int divisorsCount = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        divisorsCount++;
                }

                totalDivisors += divisorsCount;
            }

            return totalDivisors;
        }
    }
}
