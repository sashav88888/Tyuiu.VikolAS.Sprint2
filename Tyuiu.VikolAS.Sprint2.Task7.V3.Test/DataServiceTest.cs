using Tyuiu.VikolAS.Sprint2.Task7.V3.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void ValidCheckDotInShadedArea()
    {

        DataService ds = new DataService();

        double x = 0.7;
        double y = 0.7;

        bool res= ds.CheckDotInShadedArea(x, y);
        bool wait = true;
        Assert.AreEqual(wait,res);
        
    }
}