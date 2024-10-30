using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovDA.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] result = new double[len];
            int count = 0;
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Cos(x) / (x - 0.4)) + Math.Sin(x) * (8 * x) + 2;
                result[count] = Math.Round(y,2);
                count++;
            }
            return result;
        }
    }
}
