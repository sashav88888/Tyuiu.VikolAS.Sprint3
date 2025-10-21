using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task4.V1.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            double expected = 0.7677; // предварительно посчитанная сумма от -5 до -1
            double actual = ds.Calculate(-5, 5);

            // округляем до 4 знаков после запятой
            Assert.AreEqual(Math.Round(expected, 4), Math.Round(actual, 4));
        }
    }
}
