using Tyuiu.VikolAS.Sprint2.Task2.V19.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y= 4;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait,res);
        }

       
          
    }
}
