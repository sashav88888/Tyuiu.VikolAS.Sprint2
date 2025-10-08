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

            Assert.AreEqual("16.03", ds.FindDateOfNextDay(3, 15));
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 30));
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28));
            Assert.AreEqual("01.11", ds.FindDateOfNextDay(10, 31));
            Assert.AreEqual("09.09", ds.FindDateOfNextDay(9, 8));  
        }

    }
}