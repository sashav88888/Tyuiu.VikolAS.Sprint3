using System;
using Tyuiu.VikolAS.Sprint3.Task6.V16.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Обработка целочисленной информации  *");
            Console.WriteLine("* Задание #6                                  *");
            Console.WriteLine("* Вариант #16                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                   *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому отрезку [5, 16], количество всех делителей *");
            Console.WriteLine("************************************************");

            int sumDivisors = ds.GetSumTheDivisors(5, 16);
            Console.WriteLine($"Суммарное количество делителей чисел от 5 до 16: {sumDivisors}");

            Console.ReadKey();
        }
    }
}
