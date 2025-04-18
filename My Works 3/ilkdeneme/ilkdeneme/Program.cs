using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkdeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Maximum ve Minimum Değerler";
            Console.WriteLine("İnt türünün minimum değeri:{0}", int.MinValue);
            Console.WriteLine("Byte türünün minimum değeri:{0}", byte.MinValue);
            Console.WriteLine("Double türünün minimum değeri:{0}", double.MinValue);
            Console.ReadLine();
            // Console.Title = "Maximum ve Minimum Değerler";
           // Console.WriteLine("İnt türünün maksimum değeri:{0}", int.MaxValue);
            //Console.WriteLine("Byte türünün maksimum değeri:{0}", byte.MaxValue);
            //Console.WriteLine("Double türünün maksimum değeri:{0}", double.MaxValue);
            //Console.ReadLine();  (bu maximum değeri)
        }
    }
}
