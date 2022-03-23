using System;

namespace Alıştırma_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin : ");
            int number=int.Parse(Console.ReadLine());
            Console.Write(Dividend(number));
        }

        static int Dividend(int number)
        {
            int counter=0;
            for (int i = 1; i <= 200; i++)
            {
                if (i%number==0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
