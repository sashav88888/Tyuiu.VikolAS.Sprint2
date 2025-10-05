using Tyuiu.VikolAS.Sprint2.Task0.V11.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 8105;
            int y = 275;

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Операции сравнения                   *");
            Console.WriteLine("* Задание #0                                 *");
            Console.WriteLine("* Вариант #11                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ                                    *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при x = 8105, y = 275. *");
            Console.WriteLine("*****************************************    *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("x = 8105, y = 275                            *");
            Console.WriteLine("******************************************   *");
            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine("* РЕЗУЛЬТАТ:                                 *");
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"res[{i}] = {res[i]}");
            }

            Console.ReadKey();
        }
    }
}
