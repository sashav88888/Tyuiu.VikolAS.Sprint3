using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.VikolAS.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = int.MaxValue;
            int currentCount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > 0 && currentCount < minCount)
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            // Проверяем конец строки
            if (currentCount > 0 && currentCount < minCount)
            {
                minCount = currentCount;
            }

            // Если вообще нет символов item
            if (minCount == int.MaxValue)
                minCount = 0;

            return minCount;
        }
    }
}
