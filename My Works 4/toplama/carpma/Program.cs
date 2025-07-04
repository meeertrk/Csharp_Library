using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, Carp;
            for (i=1; i<=10; i++) 
            {
                for (j=1; j<10; j++) 
                {
                    Carp = i * j;
                    Console.Write("{1}*{0}={2}\t",i,j,Carp); //"\t" bir boşluk bırakmayı sağlar

                }
            Console.WriteLine();
            
            }
            Console.ReadKey();
    
        }
    }
}
