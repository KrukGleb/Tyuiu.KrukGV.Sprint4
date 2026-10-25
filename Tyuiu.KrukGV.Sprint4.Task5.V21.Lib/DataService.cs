using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KrukGV.Sprint4.Task5.V21.Lib
{
    public class DataService : ISprint4Task5V21
    {
        public int[,] Calculate(int[,] matrix)
        {
            var len = matrix.GetLength(0);
            int[, ] res = new int[len, len];

            for(int i = 0; i < len; i++)
                for (int j = 0; j < len; j++)
                    if (matrix[i, j] > 0)
                        res[i, j] = 1;
                    else
                        res[i, j] = matrix[i,j];

            return res;
        }

        
    }
}