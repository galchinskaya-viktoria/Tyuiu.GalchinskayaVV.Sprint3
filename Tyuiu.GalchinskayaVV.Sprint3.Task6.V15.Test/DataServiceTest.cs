using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task6.V15.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int actual = ds.GetSumTheDivisors(6, 15);

            int expected = 168;

            Assert.AreEqual(expected, actual);
        }
    }
}
