using Tyuiu.TomilovDA.Sprint3.Task0.V25.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(0.69, dataService.GetSumSeries(5,1,14));
        }
    }
}