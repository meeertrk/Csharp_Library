using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2adsoyad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ad, soyad, ad_soyad;

            ad = "Enis";
            soyad = "Onan";
            ad_soyad = ad + soyad;
            textBox1.Text = ad_soyad;

            bool durum = true;
            int sonuc = Convert.ToInt32(durum);
            textBox2.Text= sonuc.ToString();
        }
    }
}
