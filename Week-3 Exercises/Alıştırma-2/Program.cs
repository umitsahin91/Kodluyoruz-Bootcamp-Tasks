using System;

namespace Alıştırma_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text="abcdefghabcdefgh";
            string searching="a";

            int result=Search(text,searching);
            Console.WriteLine(result);

        }


        static int Search(string text ,string searching)
        {
            int counter=0;

            for (int i = 0; i <=text.Length-searching.Length; i++)
            {
                if (text.Substring(i,searching.Length)==searching)
                {
                    counter++;
                }
            }

             return counter;
        }
    }


}
