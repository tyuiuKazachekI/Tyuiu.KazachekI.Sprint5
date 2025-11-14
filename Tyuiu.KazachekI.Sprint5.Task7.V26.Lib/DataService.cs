using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task7.V26.Lib
{
    public class DataService: ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = Regex.Replace(text, @"\b[a-zA-Z]+\b", "word");

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V26.txt");

            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}
