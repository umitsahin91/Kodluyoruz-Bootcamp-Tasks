using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen bir sayının faktöriyelini alan program.
            */
            Console.Write("Bir sayı gitin : ");
            int fact=int.Parse(Console.ReadLine());
            Console.Write($"Girmiş olduğunuz sayının faktöriyeli : {Factorial(fact)}");
        }
        /*
        Faktöriyel hesaplayan rekürsif metot.
        */
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
