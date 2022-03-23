using System;

namespace Alıştırma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin : ");
            int number=int.Parse(Console.ReadLine());
            EvenOdd(number);
        }

        static void EvenOdd(int number)
        {
           if (number%2==0)
           {
               Console.Write(number/2);
           }
           else
           {
               Console.Write(number*2);
           }
        }
    }
}
