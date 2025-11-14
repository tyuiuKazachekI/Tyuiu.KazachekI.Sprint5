using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);
            double x = Convert.ToDouble(text.Replace(",", "."),
                System.Globalization.CultureInfo.InvariantCulture);

            double cosX = Math.Cos(x);

            if (Math.Abs(cosX) < 1e-10)
                throw new DivideByZeroException("Косинус равен нулю, деление невозможно");

            double y = 1.0 / cosX + Math.Pow(x, 3);
            return Math.Round(y, 3);
        }
    }
}