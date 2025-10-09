using Tyuiu.VikolAS.Sprint2.Task6.V8.Lib;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestPreviousDayLogic()
    {
       
        DataService ds = new DataService();

        // --- Выполнение и Проверка ---
        // Assert.AreEqual(ожидаемый_результат, реальный_результат)
        // Эта команда сравнивает то, что мы ожидаем получить, с тем, что реально вернул метод.
        // Если они совпадают - тест пройден (зеленый), если нет - провален (красный).

        // Тест 1: Обычный день в середине месяца.
        // Проверяем, что для 15 марта метод вернет "14.03".
        Assert.AreEqual("14.03", ds.FindDateOfPreviousDay(3, 15));

        // Тест 2: Переход на предыдущий месяц - Февраль (28 дней).
        // Проверяем, что для 1 марта метод вернет "28.02".
        Assert.AreEqual("28.02", ds.FindDateOfPreviousDay(3, 1));

        // Тест 3: Переход на предыдущий месяц (с 30 днями).
        // Проверяем, что для 1 мая метод вернет "30.04".
        Assert.AreEqual("30.04", ds.FindDateOfPreviousDay(5, 1));

        // Тест 4: Переход на предыдущий месяц (с 31 днем).
        // Проверяем, что для 1 августа метод вернет "31.07".
        Assert.AreEqual("31.07", ds.FindDateOfPreviousDay(8, 1));

       
        Assert.AreEqual("31.01", ds.FindDateOfPreviousDay(2, 1));

        Assert.AreEqual("09.10", ds.FindDateOfPreviousDay(10, 10));
    }
}