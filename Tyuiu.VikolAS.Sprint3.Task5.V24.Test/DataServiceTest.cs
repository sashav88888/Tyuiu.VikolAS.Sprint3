using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task5.V24.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task5.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int x = 2;

            double precise = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    precise += (Math.Pow(x, k) + 2) * Math.Sin(k);
                }
            }

            double result = ds.GetSumSumSeries(x, 1, 1, 3, 12);

            Assert.AreEqual(precise, result, 1e-6);
        }
    }
}
