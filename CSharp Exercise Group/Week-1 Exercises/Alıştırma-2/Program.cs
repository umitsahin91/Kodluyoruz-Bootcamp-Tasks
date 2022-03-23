using System;

namespace Alıştırma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Sayı:");
            int sayi1=int.Parse(Console.ReadLine());
            Console.Write("2.Sayı:");
            int sayi2=int.Parse(Console.ReadLine());
            Console.WriteLine($"{sayi1} ve {sayi2} Sayısının Toplamı : "+(sayi1+sayi2));
        }
    }
}
