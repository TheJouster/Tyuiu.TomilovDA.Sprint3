using Tyuiu.TomilovDA.Sprint3.Task7.V16.Lib;
namespace Tyuiu.TomilovDA.Sprint3.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Обработка целочисленной информации                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Томилов Дмитрий Алексеевич | ПКТб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написатьпрограмму,котораявыводиттаблицузначенийфункции:F(x)=+sin(x)*8x+2с*");
            Console.WriteLine("*сос(х)х-0,4(произвеститабулирование)f(x)назаданномдиапазоне[-5;5]сшагом1.*");
            Console.WriteLine("*.Произвестипроверкуделениянаноль.Приделениинанольвернутьзначение0.Значени*");
            Console.WriteLine("*иязанестивмассив.Значенияокруглитьдодвухзнаковпослезапятой.              *");

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

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |   F(x)   |");
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("|{0, 5:d}     | {1, 6:f2}   |", startValue, result[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("res[{0}] = {1}",i,result[i]);
            }
            Console.ReadKey();
        }
    }
}