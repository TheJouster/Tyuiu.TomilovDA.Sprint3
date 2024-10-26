using Tyuiu.TomilovDA.Sprint3.Task2.V26.Lib;
namespace Tyuiu.TomilovDA.Sprint3.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла do-while                                                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл do...while, которая вычисляет произведе*");
            Console.WriteLine("*ение ряда по формуле, при х=0,25                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите X");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стартовое значение");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.GetMultiplySeries(x,startValue,stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}