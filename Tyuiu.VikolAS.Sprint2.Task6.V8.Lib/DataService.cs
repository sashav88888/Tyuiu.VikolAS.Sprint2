using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VikolAS.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {

            int day = m;
            int month = n;

            int prevDay, prevMonth;


            if (day > 1)
            {
                prevDay = day - 1;
                prevMonth = month;
            }

            else
            {
                prevMonth = month - 1;

                switch (prevMonth)
                {
                    case 2:
                        prevDay = 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        prevDay = 30;
                        break;
                    default:
                        prevDay = 31;
                        break;
                }
            }


            return $"{prevDay:D2}.{prevMonth:D2}";
        }
    }
}