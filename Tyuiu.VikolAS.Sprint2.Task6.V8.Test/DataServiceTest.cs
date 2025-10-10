using Tyuiu.VikolAS.Sprint2.Task6.V8.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestPreviousDayLogic()
    {

        DataService ds = new DataService();
        // Проверяем 15 марта -> 14 марта. Вызываем FindDateOfPreviousDay(день, месяц)
        Assert.AreEqual("14.03", ds.FindDateOfPreviousDay(15, 3));

        // Проверяем 1 марта -> 28 февраля
        Assert.AreEqual("28.02", ds.FindDateOfPreviousDay(1, 3));

        // Проверяем 1 мая -> 30 апреля
        Assert.AreEqual("30.04", ds.FindDateOfPreviousDay(1, 5));

        // Проверяем 1 августа -> 31 июля
        Assert.AreEqual("31.07", ds.FindDateOfPreviousDay(1, 8));

        // Проверяем 1 февраля -> 31 января
        Assert.AreEqual("31.01", ds.FindDateOfPreviousDay(1, 2));

        // Проверяем случай из твоей ошибки: 25 мая -> 24 мая
        Assert.AreEqual("24.05", ds.FindDateOfPreviousDay(25, 5));
    }
}