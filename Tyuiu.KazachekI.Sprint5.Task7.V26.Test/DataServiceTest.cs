using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task7.V26.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            // Arrange
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Hello, Мир! Это Is My First Program.");

            // Act
            string outputPath = ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath);

            // Assert
            string expected = "word, Мир! Это word word word word.";
            Assert.AreEqual(expected, result);
        }
    }
}
