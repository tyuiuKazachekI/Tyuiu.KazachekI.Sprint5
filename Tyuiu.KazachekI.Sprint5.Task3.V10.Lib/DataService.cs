using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task3.V10.Lib
{
    public class DataService : ISprint5Task3V10
    {
        public string SaveToFileTextData(int x)
        {
            double result = -Math.Pow(x, 3) + 4 * Math.Pow(x, 2) - 1.5 * x;
            result = Math.Round(result, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            byte[] fileBytes = File.ReadAllBytes(path);
            string base64String = Convert.ToBase64String(fileBytes);

            return base64String; 
        }
    }
}