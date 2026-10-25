
using Tyuiu.KrukGV.Sprint4.Task3.V23.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task3.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool[] res = ds.GetCompareOperations(1065, 755);
            bool[] ans = { true, false, false, false, false, false };

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
