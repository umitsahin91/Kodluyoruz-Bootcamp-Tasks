using System;

namespace Alıştırma_3
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.Write("Kelime sayısını girin: ");
           int sayi=int.Parse(Console.ReadLine());
           string[] dizi = new string[sayi];
            for (int i = 0; i < sayi; i++)
            {
                System.Console.Write($"{i+1}. kelimeyi girin: ");
                dizi[i]=Console.ReadLine();

            }
            
            Array.Sort(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
