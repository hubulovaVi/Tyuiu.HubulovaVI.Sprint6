using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.HubulovaVI.Sprint6.Task5.V7.Lib;

namespace Tyuiu.HubulovaVI.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint6\Tyuiu.HubulovaVI.Sprint6.Task5.V7\bin\Debug\InPutFileTask5V7.txt";


        private void buttonResult_Click(object sender, EventArgs e)
        {
            dataGridViewResult.ColumnCount = 2;
            dataGridViewResult.Columns[0].Width = 20;
            dataGridViewResult.Columns[1].Width = 50;
            this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult.Series[0].Points.Clear();
            double[] massive = new double[ds.len];
            massive = ds.LoadFromDataFile(path);
            for (int i = 0; i < massive.Length; i++)
            {
                dataGridViewResult.Rows.Add(Convert.ToString(i), Convert.ToString(massive[i]));
                chartResult.Series[0].Points.AddXY(i, massive[i]);
            }


        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Хубулова Валерия Игоревна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
