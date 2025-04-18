using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonuygulama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = 3;
            x = ++y;
            Console.WriteLine(x);
            Console.Write(y);
            Console.ReadKey();
        }
    }
}
