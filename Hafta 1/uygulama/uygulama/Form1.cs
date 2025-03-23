using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string final = textBox1.Text;
            int final_not = Convert.ToInt32(final);
            bool sonuc = final_not > 50;
            if (sonuc)
                MessageBox.Show("Geçer not");
            else
                MessageBox.Show("Zayıf not");

        }
    }
}
