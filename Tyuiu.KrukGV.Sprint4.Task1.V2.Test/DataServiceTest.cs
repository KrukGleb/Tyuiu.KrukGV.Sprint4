
using Tyuiu.KrukGV.Sprint4.Task1.V2.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] data = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int res = ds.Calculate(data);


            Assert.AreEqual(34, res);
        }
    }
}
