using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KazachekI.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;

            foreach (char c in text)
            {
                if (c == '-')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
