using Tyuiu.TomilovDA.Sprint3.Task4.V15.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(623.499, dataService.Calculate(-5, 5));
        }
    }
}