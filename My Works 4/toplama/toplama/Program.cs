using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;
            Console.Write("1. Sayı:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı:");
            b = Convert.ToInt32(Console.ReadLine());
            toplam = a + b;
            Console.Write("Toplam= "+ toplam);
            Console.ReadKey();
        }
    }
}
