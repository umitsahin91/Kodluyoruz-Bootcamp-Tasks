using System;

namespace Alıştırma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı=0;
            int toplam=0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i}.Sayıyı girin: ");
                sayı=int.Parse(Console.ReadLine());
                toplam+=sayı;
                Console.Clear();
            }
            Console.Write("Girmişolduğunuz sayıların toplama : "+toplam);
            
        }
    }
}
