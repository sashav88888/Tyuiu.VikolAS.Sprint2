using Tyuiu.VikolAS.Sprint2.Task0.V11.Lib;

namespace Tyuiu.VikolAS.Sprint2.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 8105;
            int y = 275;

            bool[] wait = { true, false, true, false, true, false };
            bool[] res = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(wait, res);



        }
    }
}
