
using Tyuiu.KrukGV.Sprint4.Task5.V21.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[,] { {-1, -7, -1, -5, -6 },
{-1, -8, 1, -3, -4 },
{-3, -6, -7, -4, -5 },
{-4, -4, -6, 1, 1 },
{-4, 0, 1, 1, -4 }};

            int[,] res = ds.Calculate(mtrx);
            int[,] mtrx2 = new int[,] { {-1, -7, -1, -5, -6 },
{-1, -8, 1, -3, -4 },
{-3, -6, -7, -4, -5 },
{-4, -4, -6, 1, 1 },
{-4, 0, 1, 1, -4 }};

            CollectionAssert.AreEqual(mtrx2, res);
        }
    }
}
