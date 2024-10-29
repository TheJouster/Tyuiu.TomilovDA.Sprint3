using Tyuiu.TomilovDA.Sprint3.Task3.V15.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(1, dataService.GetMinCharCount("lrmmse mg sermmmrt",'m'));
        }
    }
}