using Tyuiu.VikolAS.Sprint2.Task3.V29.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #2 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #2                                  *");
            Console.WriteLine("* Тема: Вложенные операторы if - else        *");
            Console.WriteLine("* Задание #3                                 *");
            Console.WriteLine("* Вариант #29                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием вложенных оператор if-else, *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры. *");
            Console.WriteLine("* Округлить полученное значение до трех знаков после запятой; *");
            Console.WriteLine("*****************************************    *");
            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ds.Calculate(x);
            Console.WriteLine($"Результат: y = {result}");
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}