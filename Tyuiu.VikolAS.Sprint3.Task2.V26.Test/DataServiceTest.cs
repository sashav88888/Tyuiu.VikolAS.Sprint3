using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task2.V26.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.25;
            int startValue = 1;
            int stopValue = 17;

            double expected = 1;
            int i = startValue;

            do
            {
                expected *= (Math.Pow(x, 3) * i + 2);
                i++;
            }
            while (i <= stopValue);

            expected = Math.Round(expected, 3);

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}
