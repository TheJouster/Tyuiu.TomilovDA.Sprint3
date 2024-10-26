using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovDA.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double ans = 1;
            while (startValue <= stopValue)
            {
                ans *= Math.Pow(1 / Math.Pow(value, startValue), 3);
                startValue++;
            }
            return Math.Round(ans,3);
        }
    }
}
