using Tyuiu.TomilovDA.Sprint3.Task0.V25.Lib;
namespace Tyuiu.TomilovDA.Sprint3.Task0.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла for                                                      *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл for, которая вычисляет сумму ряда по фо*");
            Console.WriteLine("*ормуле, при X=5                                                          *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите i");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное число i");
            int stopValue = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetSumSeries(x,startValue,stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}