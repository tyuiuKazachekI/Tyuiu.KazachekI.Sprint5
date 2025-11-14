using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task1.V26.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(stopValue - startValue + 1, lines.Length);

            foreach (string line in lines)
            {
                Assert.IsFalse(string.IsNullOrWhiteSpace(line));
            }

            bool hasNumber = false;
            foreach (string line in lines)
            {
                if (double.TryParse(line, out _))
                {
                    hasNumber = true;
                    break;
                }
            }
            Assert.IsTrue(hasNumber);
        }
    }
}
