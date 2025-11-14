using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task1.V26.Lib
{
    public class DataService : ISprint5Task1V26
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    try
                    {
                        double denominator = Math.Cos(x) + x;

                        if (Math.Abs(denominator) < 0.0001)
                        {
                            writer.WriteLine("0");
                        }
                        else
                        {
                            double numerator = 2 * x + 6;
                            double value = (numerator / denominator) - 3;

                            value = Math.Round(value, 2);

                            string valueStr = value.ToString("0.##", CultureInfo.GetCultureInfo("ru-RU"));
                            writer.WriteLine(valueStr);
                        }
                    }
                    catch
                    {
                        writer.WriteLine("0");
                    }
                }
            }

            return path;
        }
    }
}
