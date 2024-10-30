using Tyuiu.TomilovDA.Sprint3.Task6.V11.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task6.V11.Test
{
    public class DataServiceTest
    {
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(9, dataService.GetSumTheDivisors(10,19));
        }
    }
}