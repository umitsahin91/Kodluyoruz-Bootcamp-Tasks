using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Verilen bir karakter dizininin substring() metodunu kullanarak string
            içerisinde arama yapan ve kaç defa geçtiğini bulan program.
            */
            string text="abcdefghabcdefgh";
            string searching="a";

            int result=Search(text,searching);
            Write(result);
        }
        /*
        Substring metodu kullanılarak metnin içerisinde arama yapan metot.
        */
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
        /*
        Sonucu ekrana yazdıran metot.
        */
        static void Write(int result)
        {
            Console.Write($"Aradığınız karakter {result} defa geçmektedir.");
        }
    }
}
