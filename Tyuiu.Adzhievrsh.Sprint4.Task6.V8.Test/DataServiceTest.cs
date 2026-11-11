using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Adzhievrsh.Sprint4.Task6.V8.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsWordsLongerThanFour()
        {
            DataService service = new DataService();

            string[] array =
            {
                "Пицца", "Борщ", "Пельмени",
                "Омлет", "Салат", "Суп", "Роллы"
            };

            string[] expected =
            {
                "Пицца", "Пельмени", "Омлет", "Салат", "Роллы"
            };

            string[] result = service.Calculate(array);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_NoMatchingElements()
        {
            DataService service = new DataService();

            string[] array = { "Суп", "Борщ" };

            string[] result = service.Calculate(array);

            Assert.AreEqual(0, result.Length);
        }
    }
}