
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VikolAS.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            if (n > 1)
            {
                // Просто отнимаем 1 от числа, месяц остается тем же.
                // :D2 - это форматирование, которое добавляет 0 впереди, если число меньше 10.
                // Например, 9 станет "09".
                return $"{(n - 1):D2}.{m:D2}";
            }

            // --- Случай 2: Сегодня 1-е число месяца ---
            // Если код дошел сюда, значит n = 1.
            // Например, сегодня 1 марта, вчера было 28 февраля.

            // Сначала вычисляем номер предыдущего месяца.
            int prevMonth = m - 1;

            // Эта переменная будет хранить последнее число предыдущего месяца.
            int lastDayOfPrevMonth;

            // Используем switch, чтобы определить, сколько дней было в *предыдущем* месяце.
            switch (prevMonth)
            {
                    case 2:
                        prevDay = 28;
                    break;

                case 4:  // Если предыдущий - апрель,
                case 6:  // июнь,
                case 9:  // сентябрь,
                case 11: // или ноябрь
                    lastDayOfPrevMonth = 30; // В них по 30 дней
                    break;

                default: // Во всех остальных месяцах (январь, март, май и т.д.)
                    lastDayOfPrevMonth = 31; // 31 день
                    break;
            }

            // Возвращаем результат: последнее число предыдущего месяца и номер предыдущего месяца.
            // Также используем форматирование :D2 для вывода в формате дд.мм.
            return $"{lastDayOfPrevMonth:D2}.{prevMonth:D2}";
        }
    }
}
