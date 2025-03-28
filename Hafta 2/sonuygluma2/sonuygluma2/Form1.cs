using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonuygluma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1= Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            sayi1 += sayi2;
            label8.Text=sayi1.ToString();

            sayi1 -= sayi2;
            label9.Text=sayi1.ToString();

            sayi1 *= sayi2;
            label10.Text=sayi1.ToString();

            sayi1 /= sayi2;
            label11.Text=sayi1.ToString();

            sayi1 %= sayi2;
            label12.Text=sayi1.ToString();
        }
    }
}
