using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonuygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 5;
            Console.WriteLine("{0} > {1}    {2}", a, b, a > b);
            Console.WriteLine("{0} < {1}    {2}", a, b, a < b);
            Console.WriteLine("{0} >= {1}    {2}", a, b, a >= b);
            Console.WriteLine("{0} <= {1}    {2}", a, b, a <= b);
            Console.WriteLine("{0} == {1}    {2}", a, b, a == b);
            Console.WriteLine("{0} != {1}    {2}", a, b, a != b);
            Console.ReadKey();
        }
    }
}
