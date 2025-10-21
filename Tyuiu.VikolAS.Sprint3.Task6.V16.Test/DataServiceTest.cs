using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task6.V16.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int start = 5;
            int stop = 16;

            // Проверяем сумму количества делителей чисел от 5 до 16
            int expected = 0;
            for (int n = start; n <= stop; n++)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        count++;
                }
                expected += count;
            }

            int result = ds.GetSumTheDivisors(start, stop);

            Assert.AreEqual(expected, result);
        }
    }
}
