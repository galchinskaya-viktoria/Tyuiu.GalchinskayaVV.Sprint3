using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GalchinskayaVV.Sprint3.Task3.V1.Lib;

namespace Tyuiu.GalchinskayaVV.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCharCount()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char ch = 'a';

            int result = ds.GetCharCount(str, ch);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
