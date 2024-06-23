using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Pr_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод MergeLists<T>() соединяет 2 списка и берёт из первого чётные элементы, а из второго нечётные
        /// </summary>
        static List<T> MergeLists<T>(List<T> list1, List<T> list2)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(list1[i]);
                }
                if (i % 2 != 0)
                {
                    result.Add(list2[i]);
                }
            }
            return result;
        }

        private async void btn_calc_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            { 
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider.SetError(textBox1, "Поле не должно быть пустым!");
                    await Task.Delay(2222); // Делей нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                    errorProvider.SetError(textBox1, "");
                }
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    errorProvider.SetError(textBox2, "Поле не должно быть пустым!");
                    await Task.Delay(2222); // Делей нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                    errorProvider.SetError(textBox2, "");
                }
            }
            else
            {
                string txt = textBox1.Text;
                string[] lines = txt.Split(',');
                List<string> lst1 = new List<string>(lines);

                string txt2 = textBox2.Text;
                string[] lines2 = txt2.Split(',');
                List<string> lst2 = new List<string>(lines2);

                List<string> list3 = MergeLists(lst1, lst2);
                textBox3.Text = String.Join(", ", list3);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void программаРасчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider.SetError(textBox1, "Поле не должно быть пустым!");
                    await Task.Delay(2222); // Делей нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                    errorProvider.SetError(textBox1, "");
                }
                if (String.IsNullOrEmpty(textBox2.Text))
                {
                    errorProvider.SetError(textBox2, "Поле не должно быть пустым!");
                    await Task.Delay(2222); // Делей нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                    errorProvider.SetError(textBox2, "");
                }
            }
            else
            {
                string txt = textBox1.Text;
                string[] lines = txt.Split(',');
                List<string> lst1 = new List<string>(lines);

                string txt2 = textBox2.Text;
                string[] lines2 = txt2.Split(',');
                List<string> lst2 = new List<string>(lines2);

                List<string> list3 = MergeLists(lst1, lst2);
                textBox3.Text = String.Join(", ", list3);
            }
        }

        private void DeleteMenuTools_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ExitMenuTools_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutProgrammMenuTools_Click(object sender, EventArgs e)
        {
            Справка newF = new Справка();
            newF.Show();
        }
    }
}
