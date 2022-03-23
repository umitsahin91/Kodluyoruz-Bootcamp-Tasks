using System;

namespace Alıştırma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac =0;
            string sesli="aeiıuüoö";
            Console.Write("Cümleyi Girin: ");
            string cumle =Console.ReadLine();

            foreach (var harf in cumle)
            {
                foreach (var sesliharf  in sesli)
                {
                    if (sesliharf==harf)
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine($"Cümlede {sayac} sesli harf vardır.");
            
        }
    }
}
