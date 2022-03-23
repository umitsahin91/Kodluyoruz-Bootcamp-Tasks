using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
             /* 
             Program that checks whether the number entered is a prime number.
             */
            
            try 
	        {	        
		        
                int dividing=2;
                int counter=0;
                Console.Write("Enter a number : ");
                int num = int.Parse(Console.ReadLine());
                
                while (dividing<num)
                {
                    if (num % dividing == 0)
                    {
                    counter++;
                    }

                    dividing++;
                }

                if (counter == 0)
                {
                Console.WriteLine("The number you enter is a prime number.");
                }
                else
                {
                Console.WriteLine("The number you enter is not a prime number.");
                }
	        }
	        
            catch (FormatException)
	        {
                Console.WriteLine("Please enter numbers only...");
	        }

            Console.ReadLine();
        }
    }
}
