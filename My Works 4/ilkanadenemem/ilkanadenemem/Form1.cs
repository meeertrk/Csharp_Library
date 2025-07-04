using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilkanadenemem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, toplam;
            a=Convert.ToInt32(textBox4.Text);
            b=Convert.ToInt32(textBox5.Text);
            toplam = a + b;
            textBox6.Text = "Toplam" + toplam;
           

        }
       
    }
}
