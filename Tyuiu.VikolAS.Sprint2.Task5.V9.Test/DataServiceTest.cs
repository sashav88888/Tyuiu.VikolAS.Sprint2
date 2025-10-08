using Tyuiu.VikolAS.Sprint2.Task5.V9.Lib;

namespace Tyuiu.VikolAS.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            Assert.AreEqual("16.3", ds.FindDateOfNextDay(3, 15));
            Assert.AreEqual("1.2", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("1.5", ds.FindDateOfNextDay(4, 30));
            Assert.AreEqual("1.3", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("1.11", ds.FindDateOfNextDay(10, 31));
        }
    }
}