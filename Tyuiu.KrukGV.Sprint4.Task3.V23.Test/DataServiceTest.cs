
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
            
            int[,] array = new int[,]
            {
            { 6, 7, 3, 5, 1 },
            { 6, 5, 2, 2, 7 },
            { 2, 6, 4, 6, 6 },
            { 7, 5, 5, 2, 6 }, 
            { 3, 1, 5, 7, 7 }  
            };
            int res = ds.Calculate(array);

            Assert.AreEqual(14, res);
        }
    }
}
