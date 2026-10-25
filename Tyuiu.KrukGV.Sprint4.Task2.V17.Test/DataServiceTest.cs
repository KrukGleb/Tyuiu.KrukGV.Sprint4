
using Tyuiu.KrukGV.Sprint4.Task2.V17.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] ans = { 6, 8, 3, 4, 6, 4, 7, 7, 3 };
            int res = ds.Calculate(ans);
            

            Assert.AreEqual(441, res);
        }
    }
}
