using Tyuiu.TomilovDA.Sprint3.Task7.V16.Lib;

namespace Tyuiu.TomilovDA.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            double[] res = new double[11];
            res[0] = -36.41;
            res[1] = -22.07;
            res[2] = 5.68;
            res[3] = 16.72;
            res[4] = 8.35;
            res[5] = -0.5;
            res[6] = 9.63;
            res[7] = 16.29;
            res[8] = 5.01;
            res[9] = -22.4;
            res[10] = -36.3;
            CollectionAssert.AreEqual(res, dataService.GetMassFunction(-5,5));
        }
    }
}