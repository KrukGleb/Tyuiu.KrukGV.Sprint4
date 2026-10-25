
using Tyuiu.KrukGV.Sprint4.Task7.V17.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "753159864";
            int res = ds.Calculate(3,3, str);
            

            Assert.AreEqual(3, res);
        }
    }
}
