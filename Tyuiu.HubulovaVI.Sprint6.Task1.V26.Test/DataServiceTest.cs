using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint6.Task1.V26.Lib;

namespace Tyuiu.HubulovaVI.Sprint6.Task1.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidArrayCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[-startValue + stopValue + 1];
            array[0] = 28.05;
            array[1] = 22.27;
            array[2] = 17.01;
            array[3] = 12.35;
            array[4] = 7.51;
            array[5] = 0;
            array[6] = 1.62;
            array[7] = -7.03;
            array[8] = -12.99;
            array[9] = -17.55;
            array[10] = -21.43;

            double[] checkArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(checkArray, array);

        }
    }
}