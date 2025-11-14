using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task7.V26.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Казачек Иван | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            try
            {
                DataService ds = new DataService();

                // Указываем путь к исходному файлу
                string path = @"C:\Users\Иван\source\repos\Tyuiu.KazachekI.Sprint5\DataSprint5\InPutDataFileTask7V26.txt";

                Console.WriteLine("Исходный текст:");
                Console.WriteLine(File.ReadAllText(path));
                Console.WriteLine();

                // Выполняем обработку
                string outputPath = ds.LoadDataAndSave(path);
                string result = File.ReadAllText(outputPath);

                Console.WriteLine("Результат обработки:");
                Console.WriteLine(result);
                Console.WriteLine();
                Console.WriteLine("Результат сохранен в файл:");
                Console.WriteLine(outputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
