using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            DataService ds = new DataService();

            double[] actual = ds.GetMassFunction(-5, 5);

            double[] expected =
            {
                -36.41,
                -22.07,
                5.68,
                16.72,
                8.35,
                -0.5,
                9.63,
                16.29,
                5.01,
                -22.4,
                -36.3
            };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
