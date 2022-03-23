using System;
using System.Collections.Generic;
namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1’den başlayıp 200’e kadar klavyeden girilen sayıya bölünen kaç adet sayı
            olduğunu veren program. (Örneğin klavyeden 6 girişi yapıldığında 1 ile 200 arasında 6’yabölünen kaç adet sayı olduğunu ekrana yazdırması gerekir.)
            */
            Console.Write("Bir sayı girin : ");
            int number=int.Parse(Console.ReadLine());
            var dividendList=Dividend(number);
            Write(dividendList,number);

        }
        /*
        1-200 arasında bölünen sayıları geriye integer türde liste olarak gönderen metot
        */
          static List<int> Dividend(int number)
        {
            int counter=0;
            List<int> dividendList=new List<int>();
            for (int i = 1; i <= 200; i++)
            {
                if (i%number==0)
                {
                    dividendList.Add(i);
                    counter++;
                }
            }
            return dividendList;
          }  
        /*
        Ekrana yazdırma işemini yapan metot.
        */
          static void Write(List<int> dividendList,int number)
          {
              Console.Write($"1 ile 200 arasında {number} ile bölünen {dividendList.Count} sayı bulumaktadır.");
              Console.WriteLine();
              foreach (var item in dividendList)
              {
                Console.Write($"{item} ");
              }
          }
    }
}
