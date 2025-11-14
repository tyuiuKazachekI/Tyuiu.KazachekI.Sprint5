using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);

            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}