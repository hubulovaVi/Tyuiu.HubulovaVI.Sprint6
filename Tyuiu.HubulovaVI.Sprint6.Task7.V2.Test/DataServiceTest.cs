using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint6.Task7.V2.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint6.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint6\Tyuiu.HubulovaVI.Sprint6.Task7.V2\bin\Debug\InPutDataFileTask7V2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}