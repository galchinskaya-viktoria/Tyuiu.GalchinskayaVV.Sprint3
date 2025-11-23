using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task4.V9.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            double actual = ds.Calculate(-5, 5);

            double expected = 1.708;

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
