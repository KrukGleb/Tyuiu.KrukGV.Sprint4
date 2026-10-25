
using Tyuiu.KrukGV.Sprint4.Task6.V16.Lib;

namespace Tyuiu.KrukGV.Sprint4.Task6.V16
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
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Крук Глеб Владиславович | НТм25-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных  ,                                          *");
            Console.WriteLine("* [\"Автомобиль\", ..., \"Метро\"], используя класс Array, выведите       *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых равна   *");
            Console.WriteLine("* 7 символам.                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string[] data = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            var len = data.Length;
            for (int i = 0; i < len; i++)
                Console.Write(data[i] + ' ');


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string[] res = ds.Calculate(data);
            len = res.Length;
            for (int i = 0; i < len; i++)
                Console.Write(res[i] + ' ');

            Console.ReadKey();
        }
    }
}