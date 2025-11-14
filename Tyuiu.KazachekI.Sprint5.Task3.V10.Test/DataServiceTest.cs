using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KazachekI.Sprint5.Task3.V10.Lib;

namespace Tyuiu.KazachekI.Sprint5.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData() 
        {
            DataService ds = new DataService();

            int x = 4;
            string base64Result = ds.SaveToFileTextData(x);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            Assert.IsTrue(File.Exists(path));

            string expectedBase64 = "AAAAAAAAGMA="; // ожидаемое значение
            Assert.AreEqual(expectedBase64, base64Result);
        }
    }
}
