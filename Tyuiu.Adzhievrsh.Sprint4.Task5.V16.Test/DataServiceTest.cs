using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint4.Task5.V16.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReplacePositiveElementsWithOne()
        {
            DataService service = new DataService();

            int[,] matrix =
            {
                { -3, 2, 0, -6, 3 },
                { 1, -4, -2, 3, -5 },
                { -1, 0, 2, -3, 1 },
                { 3, -6, -4, 0, 2 },
                { -5, 1, -2, 3, -6 }
            };

            int[,] expected =
            {
                { -3, 1, 0, -6, 1 },
                { 1, -4, -2, 1, -5 },
                { -1, 0, 1, -3, 1 },
                { 1, -6, -4, 0, 1 },
                { -5, 1, -2, 1, -6 }
            };

            int[,] result = service.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void Calculate_NoPositiveElements()
        {
            DataService service = new DataService();

            int[,] matrix =
            {
                { -1, -2, 0, -3, -4 },
                { 0, -5, -6, -1, -2 },
                { -3, -4, 0, -5, -6 },
                { -1, -2, -3, 0, -4 },
                { -5, -6, -1, -2, 0 }
            };

            int[,] result = service.Calculate(matrix);

            Assert.AreEqual(-1, result[0, 0]);
            Assert.AreEqual(0, result[0, 2]);
        }
    }
}