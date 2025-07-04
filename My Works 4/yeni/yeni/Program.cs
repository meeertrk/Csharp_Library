using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, carp;
            Console.Write("1. Sayı girin:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı girin:");
            b=Convert.ToInt32(Console.ReadLine());
            carp= a * b;
            Console.WriteLine("Toplam =" + carp);
            Console.ReadKey();
        }
    }
}
