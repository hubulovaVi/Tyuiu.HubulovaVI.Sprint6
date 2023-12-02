using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.HubulovaVI.Sprint6.Task0.V20.Lib;

namespace Tyuiu.HubulovaVI.Sprint6.Task0.V20
{
    public partial class FormBox : Form
    {
        public FormBox()
        {
            InitializeComponent();
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX.Text)));
            }
            catch
            {
                MessageBox.Show("Введены невернрые данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОИУб-23-2 Хубулова Валерия Игоревна", "Сообщение");
        }
    }
}
