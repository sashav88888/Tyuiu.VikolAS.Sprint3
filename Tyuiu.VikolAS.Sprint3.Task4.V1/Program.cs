using System;
using Tyuiu.VikolAS.Sprint3.Task4.V1.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task4.V1
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
            Console.WriteLine("* Задание #4                                  *");
            Console.WriteLine("* Вариант #1                                  *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1            *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение функции y=sin(x)/x");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения суммировать.");
            Console.WriteLine("************************************************");

            double sum = ds.Calculate(-5, 5);
            Console.WriteLine($"Сумма значений функции: {sum}");

            Console.ReadKey();
        }
    }
}
