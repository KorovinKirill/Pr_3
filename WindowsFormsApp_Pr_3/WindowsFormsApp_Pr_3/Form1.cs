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

        static List<T> MergeLists<T>(List<T> list1, List<T> list2)
        {
            List<T> result = new List<T>();

            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                if (i % 2 != 0)
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

        private void btn_calc_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            string[] lines = txt.Split(',');
            List<string> lst1 = new List<string>(lines);

            string txt2 = textBox2.Text;
            string[] lines2 = txt2.Split(',');
            List<string> lst2 = new List<string>(lines2);

            List<string> list3 = MergeLists(lst1, lst2);
            textBox3.Text = string.Join(", ", list3);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
