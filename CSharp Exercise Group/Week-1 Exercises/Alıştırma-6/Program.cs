using System;

namespace Alıştırma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Boyunuzu Girin: ");
            decimal boy=(decimal.Parse(Console.ReadLine())/100);
            Console.Write("Kilonuzu Girin: ");
            decimal kilo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Vücut Kitle İndeksiniz: "+(kilo/(boy*boy)));
            

        }
    }
}
