using Tyuiu.TomilovDA.Sprint3.Task2.V26.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(411589.537, dataService.GetMultiplySeries(0.25,1,17));
        }
    }
}