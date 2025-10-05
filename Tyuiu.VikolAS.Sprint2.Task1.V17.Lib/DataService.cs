using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VikolAS.Sprint2.Task1.V17.Lib
{
    public class DataService : ISprint2Task1V17
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            result[0] = (a > b);                       
            result[1] = (a != c) & (b > d);            
            result[2] = (a < c) | (d < b);             
            result[3] = (c > d) || (b > a);          
            result[4] = (a <= d) && (c > b);           
            result[5] = !((a >= c) ^ (b < d));         

            return result;
        }
    }
}
