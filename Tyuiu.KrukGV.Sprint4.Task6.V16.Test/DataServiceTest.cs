
using Tyuiu.KrukGV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string[] data = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = ds.Calculate(data);

            CollectionAssert.AreEqual(new[] { "Самолет", "Трамвай" }, res);
        }
    }
}
