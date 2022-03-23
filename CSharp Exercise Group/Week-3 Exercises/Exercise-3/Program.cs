using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen sayı çift ise yarısını , tek ise 2 katını alarak ekrana yazdıran
            program.(Örneğin klavyeden 14 sayısı girilirse ekrana 7,11 sayısı girilirse ekrana 22yazılması gerekir.)
            */
            Console.Write("Bir sayı girin : ");
            int number=int.Parse(Console.ReadLine());
            EvenOdd(number);
        }
        /*
        Gönderilen sayının tekmi çiftmi olduğunu kontrol edip sonucu ekrana yazdıran metot.
        */
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
