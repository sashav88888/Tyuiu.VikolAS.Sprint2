using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VikolAS.Sprint2.Task5.V9.Lib
{
    
    public class DataService : ISprint2Task5V9
    {
        // На вход: m — номер месяца, n — число.
        // На выход: строка "день.месяц" для следующего дня.
        public string FindDateOfNextDay(int m, int n)
        {
            // lastDay — последний день в месяце m
            int lastDay;

            // Используем switch, чтобы определить количество дней в месяце
            switch (m)
            {
                case 2:
                    // Февраль (по условию без високосных лет) — 28 дней
                    lastDay = 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    // Апрель, Июнь, Сентябрь, Ноябрь — 30 дней
                    lastDay = 30;
                    break;

                default:
                    // Остальные месяцы — 31 день
                    lastDay = 31;
                    break;
            }

            // Если сегодня не последний день месяца — просто увеличиваем день
            // Иначе — переходим на 1 число следующего месяца
            return (n < lastDay) ? $"{n + 1}.{m}" : $"1.{m + 1}";
        }
    }
}