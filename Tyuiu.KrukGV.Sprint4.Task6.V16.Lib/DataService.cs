using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KrukGV.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, s => s.Length == 7);
        }

    }
}