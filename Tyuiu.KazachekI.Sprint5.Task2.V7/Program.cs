using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task2.V7.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task2.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Казачек Иван | Вариант 7";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов.                    *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создаем массив 3x3 и заполняем значениями из примера
            int[,] matrix = new int[3, 3]
            {
                { 9, 2, 8 },
                { 7, 1, 2 },
                { 5, 5, 1 }
            };

            // Выводим исходный массив
            Console.WriteLine("Исходный массив:");
            PrintMatrix(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine("Создан!");

            // Выводим содержимое файла
            Console.WriteLine();
            Console.WriteLine("Содержимое файла (массив после замены нечетных элементов на 0):");
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}