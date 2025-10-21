using System;
using Tyuiu.VikolAS.Sprint3.Task7.V9.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Табулирование функции                *");
            Console.WriteLine("* Задание #7                                  *");
            Console.WriteLine("* Вариант #9                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            int start = -5;

            int end = 5;
            double[] results = ds.GetMassFunction(start, end);

            Console.WriteLine(" x\tF(x)");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{start + i}\t{results[i]:F2}");
            }

            Console.ReadKey();
        }
    }
}
