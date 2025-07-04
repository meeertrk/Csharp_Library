using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adgir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Console.Write("Ad Gir..:");
            ad = Console.ReadLine();
            Console.WriteLine("Merhaba\n" + ad); //"\n" alt satıra atıyor
            Console.ReadLine();   //Bİr tuşa basılana kadar bekle
        }
    }
}
