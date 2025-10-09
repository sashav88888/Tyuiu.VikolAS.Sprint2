using Tyuiu.VikolAS.Sprint2.Task6.V8.Lib;
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
            Console.WriteLine("* Тема: Оператор switch                      *");
            Console.WriteLine("* Задание #6                                 *");
            Console.WriteLine("* Вариант #8                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ :                                   *");
            Console.WriteLine("* Дата некоторого дня характеризуется двумя натуральными числами: m (порядковый номер месяца) и n (число) *");
            Console.WriteLine("* По заданным n и m определить дату предыдущего дня (принять, что n и m не характеризуют 1 января) *");
            Console.WriteLine("*****************************************    *");
            // --- Ввод данных от пользователя ---
            // Просим пользователя ввести номер месяца.
            Console.Write("Введите номер месяца (m): ");
            // Считываем введенную строку и преобразуем ее в целое число.
            int m = Convert.ToInt32(Console.ReadLine());

            // Просим пользователя ввести число.
            Console.Write("Введите число (n): ");
            // Также считываем и преобразуем в число.
            int n = Convert.ToInt32(Console.ReadLine());
            string result = ds.FindDateOfPreviousDay(m,n);

            // Выводим полученный результат на экран в удобном для пользователя виде.
            Console.WriteLine($"Дата предыдущего дня: {result}");

            // Ожидаем нажатия любой клавиши, чтобы консольное окно не закрылось сразу же.
            Console.ReadKey();
        }
    }
}
