using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task1.V15.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue = 1;
            int stopValue = 5;

            double expected = 1;
            int i = startValue;
            while (i <= stopValue)
            {
                expected *= (Math.Pow(x, 2) * i + 1);
                i++;
            }

            expected = Math.Round(expected, 3);

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Assert.AreEqual(expected, result);
        }
    }
}
