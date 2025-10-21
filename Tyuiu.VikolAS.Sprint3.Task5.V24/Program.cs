using System;
using Tyuiu.VikolAS.Sprint3.Task5.V24.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах *");
            Console.WriteLine("* Задание #5                                  *");
            Console.WriteLine("* Вариант #24                                  *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1            *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* при Х=2                                     *");
            Console.WriteLine("************************************************");

            int x = 2;
            double result = ds.GetSumSumSeries(x, 1, 1, 3, 12);
            Console.WriteLine($"Результат вычисления серии: {result:F6}");

            Console.ReadKey();
        }
    }
}
