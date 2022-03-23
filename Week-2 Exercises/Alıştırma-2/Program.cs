using System;

namespace Alıştırma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı girin: ");
            int sayi =int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (i%3==0&&i%7==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
