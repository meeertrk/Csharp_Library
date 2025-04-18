using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.deneme_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            a = "BURSA";
            Console.WriteLine("{0,10}", a);
            string b;
            b = "YEŞİL";
            Console.Write("{0,-8}", b); //yeşil 5 harfli ve ektra 3 boşluk bırakıyor.(-8)
            Console.WriteLine("BURSA");
            Console.ReadLine();
        }
    }
}
