using Tyuiu.TomilovDA.Sprint3.Task5.V24.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task5.V24.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(-12926.893, dataService.GetSumSumSeries(2,1,3,1,12));
        }
    }
}