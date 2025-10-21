using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint3.Task3.V3.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMinCharCount()
        {
            DataService ds = new DataService();

            string str = "cvbmzff orffgtrr dkfvfffdr";
            char symbol = 'f';

            int expected = 2;

            int result = ds.GetMinCharCount(str, symbol);

            Assert.AreEqual(expected, result);
        }
    }
}
