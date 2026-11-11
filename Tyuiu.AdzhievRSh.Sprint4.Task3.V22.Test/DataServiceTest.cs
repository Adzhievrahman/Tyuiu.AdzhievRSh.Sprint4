using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint4.Task3.V22.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsMaxElementFirstRow()
        {
            DataService service = new DataService();

            int[,] array = 
            {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 }
            };

            int result = service.Calculate(array);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Calculate_MaxElementAtBeginning()
        {
            DataService service = new DataService();

            int[,] array =
            {
                { 9, 4, 7, 8, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };

            int result = service.Calculate(array);

            Assert.AreEqual(9, result);
        }
    }
}