using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("1. Sayı:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı:");
            b= Convert.ToInt32(Console.ReadLine());
            Console.Write("{0} + {1} = {2}", a,b, a+b);
            Console.ReadKey();

        }
    }
}
