using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint4.Task2.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsProductOfOddElements()
        {
            DataService service = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 };

            int result = service.Calculate(array);

            Assert.AreEqual(225, result);
        }

        [TestMethod]
        public void Calculate_NoOddElements_ReturnsOne()
        {
            DataService service = new DataService();

            int[] array = { 2, 4, 6, 2, 4, 6 };

            int result = service.Calculate(array);

            Assert.AreEqual(1, result);
        }
    }
}