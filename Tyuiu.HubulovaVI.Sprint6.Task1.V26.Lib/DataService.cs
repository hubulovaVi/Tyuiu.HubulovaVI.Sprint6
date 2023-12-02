using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.HubulovaVI.Sprint6.Task1.V26.Lib
{
    public class DataService : ISprint6Task2V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[-startValue + stopValue + 1];
            for (int i = 0, x = startValue; x <= stopValue; x++, i++)
            {
                array[i] = Math.Round((2*Math.Cos(x)+2)/(2*x-1)+Math.Cos(x)-5*x+3, 2);
            }

            return array;
        }
    }

}