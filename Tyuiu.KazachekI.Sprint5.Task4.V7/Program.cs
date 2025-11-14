using System;
using Tyuiu.KazachekI.Sprint5.Task4.V7.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Казачек Иван | Вариант 7";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5 | Задание #4 | Вариант #7                                    *");
            Console.WriteLine("* Условие: Прочитать x из файла и вычислить y = x^3 * 1.2^x + 2          *");
            Console.WriteLine("***************************************************************************");

            string path = "InPutDataFileTask4V7.txt"; // не трогаем путь — проверка подставит свой

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
