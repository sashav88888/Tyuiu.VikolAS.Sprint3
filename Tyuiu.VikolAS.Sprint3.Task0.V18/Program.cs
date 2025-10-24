using Tyuiu.VikolAS.Sprint3.Task0.V18.Lib;
namespace Tyuiu.VikolAS.Sprint3.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = ("Спринт #3 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #3                                  *");
            Console.WriteLine("* Тема: Оператор цикла for                   *");
            Console.WriteLine("* Задание #0                                 *");
            Console.WriteLine("* Вариант #18                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда по формуле, при X=1 *");
            Console.WriteLine("*****************************************    *");


            int x = 1;
            int start = 1;
            int stop = 6;

            double result = ds.GetMultiplySeries(x, start, stop);

            Console.WriteLine($"Результат вычисления p = {result}");
            Console.ReadKey();
        }
    }
}

