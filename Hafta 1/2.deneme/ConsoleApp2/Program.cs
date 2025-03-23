using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Bir sayı giriniz:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write(x);
            Console.ReadKey();
        }
    }
}
