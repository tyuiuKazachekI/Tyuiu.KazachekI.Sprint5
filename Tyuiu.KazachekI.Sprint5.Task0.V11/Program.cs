using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task0.V11.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task0.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Казачек Иван | Вариант 11";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить выражение y = 4 - x^3/x^2 при x = 3                           *");
            Console.WriteLine("* Сохранить результат в файл OutPutFileTask0.txt                          *");
            Console.WriteLine("* и вывести путь к файлу на консоль.                                      *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            // Выведем содержимое файла
            string result = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
