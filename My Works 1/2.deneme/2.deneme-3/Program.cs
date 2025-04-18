using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.deneme_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 15000;
            Console.WriteLine("Sayı {0:C}", x);
            Console.WriteLine("Sayı {0:D15}", x);
            Console.WriteLine("Sayı {0:E}", x);
            Console.WriteLine("Sayı {0:F3}", x);
            Console.WriteLine("Sayı {0:N}", x);
            Console.WriteLine("Sayı {0:X}", x);
            Console.WriteLine("{0:### ##}", x);

            Console.ReadLine();
        }
    }
}
