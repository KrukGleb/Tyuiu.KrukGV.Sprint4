
using Tyuiu.KrukGV.Sprint4.Task0.V30.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task0.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Крук Г. В. | НТм25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9                           *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("* {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] data = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            Console.WriteLine("data = " + string.Join(",", data));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetSumEvenArrEl(data);
            Console.WriteLine(res);
            
            Console.ReadKey();
        }
    }
}