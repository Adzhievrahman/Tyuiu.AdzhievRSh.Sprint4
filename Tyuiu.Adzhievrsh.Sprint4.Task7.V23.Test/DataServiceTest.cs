using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AdzhievRSh.Sprint4.Task7.V23.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ReturnsCountEvenNumbers()
        {
            DataService service = new DataService();

            string value = "678135972584";

            int result = service.Calculate(4, 3, value);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Calculate_AllNumbersEven()
        {
            DataService service = new DataService();

            string value = "246824682468";

            int result = service.Calculate(4, 3, value);

            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Calculate_AllNumbersOdd()
        {
            DataService service = new DataService();

            string value = "135791357913";

            int result = service.Calculate(4, 3, value);

            Assert.AreEqual(0, result);
        }
    }
}