using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task2.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            double result = ds.GetSumSeries(a, 1, 20);

            double expected = 0.298;

            Assert.AreEqual(expected, result);
        }
    }
}
