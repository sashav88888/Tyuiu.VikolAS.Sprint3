using System;
using Tyuiu.VikolAS.Sprint3.Task2.V26.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Оператор цикла Do-While               *");
            Console.WriteLine("* Задание #2                                  *");
            Console.WriteLine("* Вариант #26                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1            *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* Написать программу, используя цикл do...while,*");
            Console.WriteLine("* которая вычисляет произведение ряда по      *");
            Console.WriteLine("* формуле p = Π((x^3 * i) + 2), при x = 0.25. *");
            Console.WriteLine("************************************************");

            double x = 0.25;
            int startValue = 1;
            int stopValue = 17;

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine($"Результат вычислений: {result}");

            Console.ReadKey();
        }
    }
}
