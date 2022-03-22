using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 
             * Program that detects that the entered number is a prime number
             */
            
            try 
	        {	        
		        int num;
                int counter=0;
                Console.WriteLine("Enter a number : ");
                number = int.Parse(Console.ReadLine());
                int i=2;

                while (i<num)
                {
                    if (num % i == 0)
                    {
                    counter++;
                    }

                    i++;
                }

                if (counter != 0)
                {
                Console.WriteLine("Number is NOT Prime");
                }
                else
                {
                Console.WriteLine("Number is PRIME");
                }
	        }
	        
            catch (FormatException)
	        {
                Console.WriteLine("Please enter numbers only");
	        }

            Console.ReadLine();
        }
    }
}
