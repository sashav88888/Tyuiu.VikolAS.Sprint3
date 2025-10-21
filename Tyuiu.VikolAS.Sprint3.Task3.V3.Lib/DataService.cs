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
                    // учитываем только группы, где символов было >= 2
                    if (currentCount >= 2 && currentCount < minCount)
                    {
                        minCount = currentCount;
                    }
                    currentCount = 0;
                }
            }

            // Проверка конца строки
            if (currentCount >= 2 && currentCount < minCount)
            {
                minCount = currentCount;
            }

            // Если не найдено ни одной группы подряд идущих символов
            if (minCount == int.MaxValue)
            {
                return 0;
            }

            return minCount;
        }
    }
}
