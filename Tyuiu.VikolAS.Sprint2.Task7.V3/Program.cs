using Tyuiu.VikolAS.Sprint2.Task7.V3.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
            Console.WriteLine("* Задание #7                                 *");
            Console.WriteLine("* Вариант #3                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет, *");
            Console.WriteLine("* находится ли точка с координатами X,Y в заштрихованной области. *");
            Console.WriteLine("*****************************************    *");

            Console.Write("Введите X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine("Точка находится в заштрихованной области.");
            }
            else
            {
                Console.WriteLine("Точка находится вне заштрихованной области.");
            }

            Console.ReadKey();
        }
    }
}
