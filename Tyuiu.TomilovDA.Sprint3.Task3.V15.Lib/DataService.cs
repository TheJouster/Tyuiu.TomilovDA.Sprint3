using System.Collections.Specialized;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.TomilovDA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = 99999;
            int count = 0;
            char prevChar = ' ';
            foreach (char c in value)
            {
                if (c == item && prevChar == item)
                {
                    count++;
                }
                else if (c == item)
                {
                    count = 1;
                }
                else
                {
                    count = 0;
                }
                if (count < minCount && count != 0)
                {
                    minCount = count;
                }
                prevChar = c;
            }
            return minCount;
        }
    }
}
