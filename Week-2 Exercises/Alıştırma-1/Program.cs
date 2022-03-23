using System;

namespace Alıştırma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            int sayac=0;

            for (int i = 2; i < 1000000; i++)
            {
                while (sayi < i)
                {
                    if (i % sayi == 0)
                        sayac++;

                    sayi++;
                }
                
                if (sayac==0)
                {
                    Console.WriteLine(i);
                }
                sayac=0;
                sayi=2;
            }
        }
    }
}
