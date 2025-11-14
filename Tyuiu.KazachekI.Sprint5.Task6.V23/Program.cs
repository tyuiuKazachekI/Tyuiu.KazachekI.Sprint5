using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task6.V23.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Казачек Иван | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.                       *");
            Console.WriteLine("* Найти количество знаков тире '-' в заданной строке.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint5\DataSprint5\InPutDataFileTask6V23.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Количество знаков тире: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
