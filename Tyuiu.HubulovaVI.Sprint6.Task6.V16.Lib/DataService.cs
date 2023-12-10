using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    string[] words = line.Split(' ');

                    foreach (string word in words)
                    {
                        if (word.Contains('b'))
                        {
                            resStr += word + " ";
                        }

                    }
                }
            }
            return resStr;

        }
    }
}
        