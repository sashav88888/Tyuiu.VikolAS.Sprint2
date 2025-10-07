using Tyuiu.VikolAS.Sprint2.Task4.V14.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task4.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Тернарный оператор                   *");
            Console.WriteLine("* Задание #4                                 *");
            Console.WriteLine("* Вариант #14                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, *");
            Console.WriteLine("* где пользователь вводит значение переменной X,Y с клавиатуры. *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой; *");
            Console.WriteLine("*****************************************    *");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x, y);
            Console.WriteLine($"Результат: z = {result}");

            Console.ReadKey();
        }
    }
}