
using Tyuiu.KrukGV.Sprint4.Task1.V2.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task1.V2
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 14 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 7                           *");
            Console.WriteLine("* подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("* С клавиатуры: 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int[] data = new int[14];
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"Введите элемент массива [{i}]: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(data);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}