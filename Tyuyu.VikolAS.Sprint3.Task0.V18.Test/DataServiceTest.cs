using Tyuyu.VikolAS.Sprint3.Task0.V18.Lib;
namespace Tyuyu.VikolAS.Sprint3.Task0.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double result = ds.GetMultiplySeries(1, 1, 6);


            // Проверяем ожидаемое значение
            double expected = Math.Round(
                Math.Pow(2 / (Math.Cos(1) + 0.5), 1) *
                Math.Pow(2 / (Math.Cos(1) + 0.5), 2) *
                Math.Pow(2 / (Math.Cos(1) + 0.5), 3) *
                Math.Pow(2 / (Math.Cos(1) + 0.5), 4) *
                Math.Pow(2 / (Math.Cos(1) + 0.5), 5) *
                Math.Pow(2 / (Math.Cos(1) + 0.5), 6), 3);

            Assert.AreEqual(expected, result);
        }
    }
}
