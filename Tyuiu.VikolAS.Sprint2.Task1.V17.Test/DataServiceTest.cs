using Tyuiu.VikolAS.Sprint2.Task1.V17.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestLogicOperations()
        {
            DataService ds = new DataService();

            int a = 135, b = 123, c = 455, d = 321;

            bool[] wait = { true, false, true, true, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
