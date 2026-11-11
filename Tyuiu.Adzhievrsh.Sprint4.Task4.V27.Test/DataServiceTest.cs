using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint4.Task4.V27.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsSumOfOddElements()
        {
            DataService service = new DataService();

            int[,] matrix =
            {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            int result = service.Calculate(matrix);

            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void Calculate_NoOddElements_ReturnsZero()
        {
            DataService service = new DataService();

            int[,] matrix =
            {
                { 2, 4, 6, 8, 2 },
                { 4, 6, 8, 2, 4 },
                { 6, 8, 2, 4, 6 },
                { 8, 2, 4, 6, 8 },
                { 2, 4, 6, 8, 2 }
            };

            int result = service.Calculate(matrix);

            Assert.AreEqual(0, result);
        }
    }
}