using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBLr4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            bool rez1 = int.TryParse(textBox1.Text, out a);
            if (rez1 == false)
            {
                MessageBox.Show("Неверный формат числа" + textBox1.Text + " ");
                return;
            }
            bool rez2 = int.TryParse(textBox2.Text, out b);
            if (rez2 == false)
            {
                MessageBox.Show(" Неверный формат числа " + textBox2.Text + " ");
                return;
            }
            c = 2 * (5 * a + 6 * b) / 5;
            string cStr = c.ToString();
            label8.Text = cStr;
            return;
        }
    }
}
