using Tyuiu.VikolAS.Sprint2.Task4.V14.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.VikolAS.Sprint2.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2, 10);

            double wait = Math.Round(Math.Pow(2 + 1 / Math.Pow(2, 2), 10), 3);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(10, 5);

            double wait = Math.Round(
                (Math.Pow(5, 2) - Math.Pow(Math.Cos(10), 2) + 10) /
                (Math.Pow(10, 2) - Math.Pow(Math.Sin(5), 2) + 12), 3);

            Assert.AreEqual(wait, res);
        }
    }
}