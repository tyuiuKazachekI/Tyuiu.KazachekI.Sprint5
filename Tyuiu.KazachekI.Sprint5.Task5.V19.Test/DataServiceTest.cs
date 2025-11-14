using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task5.V19.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
     
        public void ValidLoadFromDataFileCalculation()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            string[] testData = {
                "16", "15.24", "9", "8", "11", "19", "-3.43", "-6", "9.4", "20",
                "11.67", "1.72", "12.7", "10.45", "-4", "17.23", "6.45", "6.7", "-7.58", "-0.74"
            };

            File.WriteAllLines(path, testData);

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат: {res}");

            double min = double.MaxValue;
            double max = double.MinValue;
            foreach (string line in testData)
            {
                if (double.TryParse(line, out double num))
                {
                    double rounded = Math.Round(num, 3);
                    if (rounded < min) min = rounded;
                    if (rounded > max) max = rounded;
                }
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Разница: {max - min}");

            File.Delete(path);
        }
    }
}