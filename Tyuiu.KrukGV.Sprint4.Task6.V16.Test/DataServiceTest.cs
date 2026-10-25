
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
            bool[] res = ds.GetCompareOperations(1065, 755);
            bool[] ans = { true, false, false, false, false, false };

            CollectionAssert.AreEqual(ans, res);
        }
    }
}
