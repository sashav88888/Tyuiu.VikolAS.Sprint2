using Tyuiu.VikolAS.Sprint2.Task5.V9.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Оператор switch                      *");
            Console.WriteLine("* Задание #5                                 *");
            Console.WriteLine("* Вариант #9                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число). *");
            Console.WriteLine("* По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря). *");
            Console.WriteLine("*****************************************    *");

            Console.Write("Введите номер месяца (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ds.FindDateOfNextDay(m, n));


            Console.ReadKey();
        }
    }
}
