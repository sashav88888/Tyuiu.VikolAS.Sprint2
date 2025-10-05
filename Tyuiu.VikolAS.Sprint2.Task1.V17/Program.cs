using Tyuiu.VikolAS.Sprint2.Task1.V17.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task1.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 135, b = 123, c = 455, d = 321;

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Логические операции                  *");
            Console.WriteLine("* Задание #1                                 *");
            Console.WriteLine("* Вариант #17                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ                                    *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций (|, &, ||, &&, !, ^,  *");
            Console.WriteLine("  последовательность операций не должна нарушаться), а также арифметических выражений, которая вернет логическую *");
            Console.WriteLine("*****************************************    *");
            Console.WriteLine("* последовательность(массив): (True, False, True, True, True, False) *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("a = 135, b = 123, c = 455, d = 321           *");
            Console.WriteLine("******************************************   *");

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"[{i}] = {res[i]}");
            }

            Console.ReadKey();
        }
    }
}
