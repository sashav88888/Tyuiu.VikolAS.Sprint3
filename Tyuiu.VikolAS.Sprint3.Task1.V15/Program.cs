using System;
using Tyuiu.VikolAS.Sprint3.Task1.V15.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Оператор цикла While.               *");
            Console.WriteLine("* Задание #1                                  *");
            Console.WriteLine("* Вариант #15                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1            *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* Написать программу, используя цикл while,   *");
            Console.WriteLine("* которая вычисляет произведение ряда по      *");
            Console.WriteLine("* формуле p = (Π(x^2 * i)) + 1, при x = 2.   *");
            Console.WriteLine("************************************************");


            int x = 2;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine();
            Console.WriteLine($"Результат вычислений: {res}");

            Console.ReadKey();
        }
    }
}