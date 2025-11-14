using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task6.V23.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDashCount()
        {
            DataService ds = new DataService();

            string path = "test_file.txt";
            File.WriteAllText(path, "hello-world test-data");

            int result = ds.LoadFromDataFile(path);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}