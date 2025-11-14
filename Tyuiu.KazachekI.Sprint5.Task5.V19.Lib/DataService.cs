using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            int minSingleDigit = 10;
            int maxSingleDigit = -10;
            bool foundSingleDigit = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string numStr in numbers)
                    {
                        if (double.TryParse(numStr, out double num))
                        {
                            double rounded = Math.Round(num, 3);

                            if (rounded >= -9 && rounded <= 9 &&
                                Math.Abs(rounded - Math.Round(rounded)) < 0.001)
                            {
                                int intNum = (int)Math.Round(rounded);
                                foundSingleDigit = true;

                                if (intNum < minSingleDigit) minSingleDigit = intNum;
                                if (intNum > maxSingleDigit) maxSingleDigit = intNum;
                            }
                        }
                    }
                }
            }

            if (foundSingleDigit)
            {
                return maxSingleDigit - minSingleDigit;
            }

            return 0;
        }
    }
}
