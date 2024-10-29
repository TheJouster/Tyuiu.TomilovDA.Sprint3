using Tyuiu.TomilovDA.Sprint3.Task4.V15.Lib;
namespace Tyuiu.TomilovDA.Sprint3.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Использование операторов continue и break в циклах                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функц*");
            Console.WriteLine("*ции y=((sin(x)+x)/x)+0.75 При х = 0 пропустить значение Полученные значен*");
            Console.WriteLine("*ния перемножать.                                                         *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите стартовое значение");
            int startValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите конечное значение");
            int stopValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.Calculate(startValue,stopValue);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}