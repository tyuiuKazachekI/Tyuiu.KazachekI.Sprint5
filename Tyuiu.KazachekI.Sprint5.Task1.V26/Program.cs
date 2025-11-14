using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task1.V26.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task1.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Казачек Иван | Вариант 26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = (2x+6)/(cos(x)+x) - 3                              *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.           *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask1.txt и вывести на консоль.    *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");

            // Выводим таблицу на консоль
            Console.WriteLine();
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("x\tF(x)");

            string[] lines = File.ReadAllLines(path);
            int x = startValue;
            foreach (string line in lines)
            {
                Console.WriteLine($"{x}\t{line}");
                x++;
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}