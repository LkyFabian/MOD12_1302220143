using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD12_1302220143
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            if (b < 0)
            {
                return -1;
            }
            if (b > 10)
            {
                return -2;
            }
            int hasil = a;

            for (int i = 1; i < b; i++)
            {
                if (hasil > int.MaxValue / a)
                {
                    return -3;
                }
                hasil *= a;
            }
            return hasil;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label1.Text = $"pangkat:{CariNilaiPangkat(a,b).ToString()}";    
        }
    }
}
