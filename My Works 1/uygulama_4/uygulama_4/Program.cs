using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, fark = 0, carpim = 0, kalan = 0;
            float bolum = 0;
            int sayi1 = 0, sayi2 = 0;

            Console.WriteLine("1. Sayıyı Giriniz:");
            sayi1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz:");
            sayi2= Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            fark= sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            kalan= sayi1 % sayi2;
            bolum= sayi1 / sayi2;

            Console.WriteLine("Girilen Sayılar: Sayı 1 = {0}, Sayı 2 = {1}", sayi1, sayi2);
            Console.WriteLine("Girilen Sayılar: Sayı 1 ="+ sayi1 + ", Sayı 2 ="+ sayi2); //üsttekini 2. yolu
            Console.WriteLine("Sayıların Toplamı = {0}", toplam);
            Console.WriteLine("Sayıların Farkı (sayi1 - sayi2) = {0}", fark);
            Console.WriteLine("Sayıların Çarpımı ={0}", carpim);
            Console.WriteLine("Sayıları Kalanı (sayi1 in sayi2 ye bölümünden kalan ={0}", kalan);
            Console.WriteLine("Sayıların Bölümünden (sayi1 / sayi2 ) Bölüm = {0}", bolum);
            sayi1++;
            sayi2--;
            Console.WriteLine("Sayi 1 in bir fazlası = {0}", sayi1);
            Console.WriteLine("Sayi 2 nin bir eksiği = {0}", sayi2);
            Console.ReadKey();

        }
    }
}
