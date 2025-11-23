using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task0.V11.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSumSeries()
        {
            DataService ds = new DataService();

            double result = ds.GetSumSeries(5, 1, 10);

            double expected = 0.042;

            Assert.AreEqual(expected, result);
        }
    }
}
