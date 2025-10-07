using Tyuiu.VikolAS.Sprint2.Task3.V29.Lib;
namespace Tyuiu.VikolAS.Sprint2.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 486.000;
            Assert.AreEqual(wait, res, 0.001);
            
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.000; 
            Assert.AreEqual(wait, res, 0.001);

        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.640;
            Assert.AreEqual(wait, res, 0.001);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -33;
            double res = ds.Calculate(x);
            double wait = -362.970;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
