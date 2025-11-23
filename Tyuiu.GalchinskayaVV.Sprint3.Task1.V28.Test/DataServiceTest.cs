using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task1.V28.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            double result = ds.GetSumSeries(a, 1, 18);

            double expected = -0.186;

            Assert.AreEqual(expected, result);
        }
    }
}
