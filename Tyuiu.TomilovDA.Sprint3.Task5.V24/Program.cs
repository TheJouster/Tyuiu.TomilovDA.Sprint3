using Tyuiu.TomilovDA.Sprint3.Task5.V24.Lib;
namespace Tyuiu.TomilovDA.Sprint3.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Вложенные циклы                                                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*при Х=2                                                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стартовое значение1");
            int startValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение1");
            int stopValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стартовое значение1");
            int startValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение1");
            int stopValue2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}