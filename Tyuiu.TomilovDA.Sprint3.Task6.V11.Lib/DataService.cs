using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovDA.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j > 10)
                    {
                        if (i % j == 0)
                        {

                            sum += 1;
                        }
                    }
                }
            }
            return sum;
        }
    }
}
