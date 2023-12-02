using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.HubulovaVI.Sprint6.Task1.V26.Lib;

namespace Tyuiu.HubulovaVI.Sprint6.Task1.V26
{
    public partial class FormMainn : Form
    {
        public FormMainn()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = int.Parse(textBoxStart.Text);
                int stopValue = int.Parse(textBoxEnd.Text);

                double[] array = ds.GetMassFunction(startValue, stopValue);

                string str = null;
                textBoxResult.AppendText("+-----------+------------+" + "\r\n");
                textBoxResult.AppendText("|     X     |    f(x)    |" + "\r\n");
                textBoxResult.AppendText("+-----------+------------+" + "\r\n");
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    str = string.Format("|{0,6}     |  {1, 6}    |", startValue, array[i]);
                    textBoxResult.AppendText(str + "\r\n");
                    startValue++;
                }
                textBoxResult.AppendText("+-----------+------------+" + "\r\n");
            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 Вариант 26 выполнил студент группы АСОИУб-23-2 Хубулова Валерия Игоревна", "Сообщение");
        }
    }
}