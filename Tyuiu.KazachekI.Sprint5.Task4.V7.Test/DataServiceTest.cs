using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task4.V7.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask4.txt");
            File.WriteAllText(path, "3.5"); 

            double result = ds.LoadFromDataFile(path);

            double expected = 41.807;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
    
    
}