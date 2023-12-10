using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint6.Task5.V7.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReadData()
        {
            string path = $@"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint6\Tyuiu.HubulovaVI.Sprint6.Task5.V7\bin\Debug\InPutFileTask5V7.txt";
            FileInfo file = new FileInfo(path);
            bool res = file.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}