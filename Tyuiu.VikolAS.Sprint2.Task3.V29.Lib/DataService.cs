using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VikolAS.Sprint2.Task3.V29.Lib
{
    public class DataService : ISprint2Task3V29
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x * Math.Pow((x + 1) / (x - 1), 5);
            }
            else if (x == 0)
            {
                double numerator = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 6;
                double denominator = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 5;
                y = numerator / denominator;
            }
            else if (x > -33 && x < 2)
            {
                y = Math.Pow(1 + (1 / Math.Pow(x, 2)), x);
            }
            else if (x <= -33)
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
