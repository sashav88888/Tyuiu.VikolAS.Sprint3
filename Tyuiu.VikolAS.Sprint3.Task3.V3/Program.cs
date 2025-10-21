using System;
using Tyuiu.VikolAS.Sprint3.Task3.V3.Lib;

namespace Tyuiu.VikolAS.Sprint3.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #3                                   *");
            Console.WriteLine("* Тема: Оператор цикла foreach                *");
            Console.WriteLine("* Задание #3                                  *");
            Console.WriteLine("* Вариант #3                                  *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1            *");
            Console.WriteLine("************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                    *");
            Console.WriteLine("* Используя цикл foreach, подсчитать          *");
            Console.WriteLine("* минимальное количество букв 'f',            *");
            Console.WriteLine("* находящихся на соседних позициях в строке:  *");
            Console.WriteLine("* cvbmzff orffgtrr dkfvfffdr                  *");
            Console.WriteLine("************************************************");

            string str = "cvbmzff orffgtrr dkfvfffdr";
            char symbol = 'f';

            int result = ds.GetMinCharCount(str, symbol);

            Console.WriteLine();
            Console.WriteLine($"Минимальное количество подряд идущих '{symbol}': {result}");

            Console.ReadKey();
        }
    }
}
