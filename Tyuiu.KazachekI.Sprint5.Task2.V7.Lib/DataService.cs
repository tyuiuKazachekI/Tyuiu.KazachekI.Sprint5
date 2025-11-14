using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task2.V7.Lib
{
    public class DataService : ISprint5Task2V7
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] line = new string[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            line[j] = "0";
                        }
                        else
                        {
                            line[j] = matrix[i, j].ToString();
                        }
                    }

                    writer.WriteLine(string.Join(";", line));
                }
            }

            return path;
        }
    }
}