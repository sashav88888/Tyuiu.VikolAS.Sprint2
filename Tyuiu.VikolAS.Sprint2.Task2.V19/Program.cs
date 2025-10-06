using Tyuiu.VikolAS.Sprint2.Task2.V19.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Оператор if                          *");
            Console.WriteLine("* Задание #2                                 *");
            Console.WriteLine("* Вариант #19                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ                                    *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится ли точка с координатами X,Y в заштрихованной области. *");
            Console.WriteLine("*****************************************    *");
            Console.Write("Введите X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите Y: ");
            int y = int.Parse(Console.ReadLine());
            bool result = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("********************************************");
            Console.WriteLine($"РЕЗУЛЬТАТ: точка ({x},{y}) → {result}");
            Console.WriteLine("********************************************");

            Console.ReadKey();
        }
    }
}