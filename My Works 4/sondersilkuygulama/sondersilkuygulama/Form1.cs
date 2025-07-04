using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sondersilkuygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, kdv_orani, toplam;
            fiyat =Convert.ToDouble(textBox1.Text);
            kdv_orani = Convert.ToDouble(textBox2.Text);

            toplam = (fiyat + fiyat * (kdv_orani / 100));

            textBox3.Text = toplam.ToString();
            

        }
    }
}
