using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint4.Task1.V1.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = { 8, 2, 7, 5, 0, 7, 4, 7, 5, 7 };

            int result = ds.Calculate(array);

            int wait = 14;

            Assert.AreEqual(wait, result);
        }
    }
}