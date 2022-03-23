using System;

namespace Alıştırma_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        static int Factorial(int number)
        {
            if (number==1)
            {
                return 1;
            }
            else
            {
                return number*Factorial(number-1);
            }
        }
    }
}
