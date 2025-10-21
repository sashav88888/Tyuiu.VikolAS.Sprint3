using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task7.V9.Lib;
using System;

namespace Tyuiu.VikolAS.Sprint3.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            // Простейшая проверка: длина массива
            Assert.AreEqual(11, result.Length);

            // Проверка на ноль при cos(x)=0 (x = π/2 ≈ 1.57, 3π/2 ≈ 4.71) – в нашем диапазоне [-5,5] это x=1, x=5 не делится на π/2 точно, но проверим просто не NaN
            foreach (double val in result)
            {
                Assert.IsFalse(Double.IsNaN(val));
            }


            // Пример проверки конкретного значения
            Assert.AreEqual(Math.Round((2 * (-5) - 3) / Math.Cos(-5) - 2 * (-5) + 5 * (-5) - Math.Sin(-5), 2), result[0]);
        }
    }
}
