using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonuygulamason
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double vize, final, ortalama;

            ad= textBox1.Text;
            soyad=textBox2.Text;

            vize= Convert.ToDouble(textBox3.Text);
            final= Convert.ToDouble(textBox4.Text);
            ortalama = vize * 0.4 + final * 0.6;

            listBox1.Items.Add("Adınız:"+ ad + " Soyadınız:" + soyad + " Ortalamanız=" + ortalama);
            listBox1.Items.Add(ad + " " + soyad + " Ortalama=" + ortalama.ToString("0.00")); //2. gösterim çokta gerek değil
        }
    }
}
