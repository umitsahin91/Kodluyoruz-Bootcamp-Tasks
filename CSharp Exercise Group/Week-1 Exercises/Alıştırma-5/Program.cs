using System;

namespace Alıştıma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Girin: ");
            int sayi = int.Parse(Console.ReadLine());
            if(sayi<0 || sayi>100)
                Console.Write("Girmiş olduğunuz sayı 0-100 aralığında değildir");
            else
                Console.Write("Girmiş olduğunuz sayı 0-100 aralığındadır");
        }
    }
}
