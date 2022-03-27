using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Program listing prime numbers between 1-10000
            */
            
            int num = 2;
            int counter=0;

            for (int i = 2; i < 10000; i++)
            {
                while (num < i)
                {
                    if (i % num == 0)
                        counter++;

                    num++;
                }
                
                if (counter==0)
                {
                    Console.Write(i+" ");
                }
                counter=0;
                num=2;
            }
        }
    }
}
