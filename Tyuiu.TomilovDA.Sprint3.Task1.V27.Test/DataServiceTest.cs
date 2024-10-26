using Tyuiu.TomilovDA.Sprint3.Task1.V27.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(419028.1, dataService.GetMultiplySeries(0.75,1,5));
        }
    }
}