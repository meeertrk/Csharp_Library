using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte a = 255;
            short b = 32767; // max değer
            int c = 21474836;
            long d = 9223372036854775807;
            float f = 7.1234568f; // max 7 bas., 8. bas yuvarladı
            double g = 21212.3321;
            decimal h = 7.9000000000000000000000000000M; //27 sıfır var
            decimal i = 7.9E+28M; //max 29 bas.
            bool k = true;
            char m = 'A';
            string n = "Çok çalışmam lazım çok";
            object p = 123;
            object r = "Merhaba ASP";
            object s = true;
            label1.Text = "Byte değişken:" + a; //değişken yazdırılıyor
            label2.Text = "Short değişken:" + b;
            label3.Text = "İnteger değişken:" + c;
            label4.Text = "Long değişken:" + d;
            label5.Text = "Float değişken:" + f;
            label6.Text = "Double değişken:" + g;
            label7.Text = "1. Decimal değişken:" + h;
            label8.Text = "2. Decimal değişken:" + i;
            label9.Text = "Boolean değişken:" + k;
            label10.Text = "Char değişken:" + m;
            label11.Text = "String değişken:" + n;
            label12.Text = "1. Object değişken:" + p;
            label13.Text = "2. Object değişken:" + r;
            label14.Text = "3. Object değişken:" + s;
        }
    }
}
