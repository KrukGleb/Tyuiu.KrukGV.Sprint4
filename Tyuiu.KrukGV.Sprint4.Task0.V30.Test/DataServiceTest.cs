
using Tyuiu.KrukGV.Sprint4.Task0.V30.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] data = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(data);


            Assert.AreEqual(30, res);
        }
    }
}
