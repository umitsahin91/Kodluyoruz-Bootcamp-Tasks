using System;

namespace Alıştırma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi==0)
            {
                Console.WriteLine("Girmiş olduğunuz sayı ÇİFT sayıdır.");

            }
            else{
                Console.WriteLine("Girmiş olduğunuz sayı TEK sayıdır.");
            }
        }
    }
}
