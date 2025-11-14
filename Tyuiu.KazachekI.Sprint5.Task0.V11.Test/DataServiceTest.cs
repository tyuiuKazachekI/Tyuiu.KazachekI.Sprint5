using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task0.V11.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

            Assert.AreEqual("-2,556", result);
        }
    }
}
