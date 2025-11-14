using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task3.V10.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;

            DataService ds = new DataService();
            string base64String = ds.SaveToFileTextData(x);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Читаем и выводим результат из бинарного файла
            double resultFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                resultFromFile = reader.ReadDouble();
            }

            double calculatedResult = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            calculatedResult = Math.Round(calculatedResult, 3);

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Значение функции при x = {x}: {calculatedResult}");
            Console.WriteLine($"Прочитано из файла: {resultFromFile}");
            Console.WriteLine($"Base64: {base64String}");

            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}