using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task5.V24.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeriesValid()
        {
            DataService ds = new DataService();

            double actual = ds.GetSumSumSeries(2, 1, 1, 3, 12);

            double expected = -12926.893;

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
