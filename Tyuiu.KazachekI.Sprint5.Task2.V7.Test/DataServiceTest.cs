using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task2.V7.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 9, 2, 8 },
                { 7, 1, 2 },
                { 5, 5, 1 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);

            Assert.IsTrue(fileContent.Contains("0;2;8"));
            Assert.IsTrue(fileContent.Contains("0;0;2"));
            Assert.IsTrue(fileContent.Contains("0;0;0"));

            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(3, lines.Length);

            foreach (string line in lines)
            {
                string[] values = line.Split(';');
                Assert.AreEqual(3, values.Length);
            }
        }
    }
}