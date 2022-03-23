using System;

namespace Alıştırma_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cümle Giriniz: ");
            string cumle=Console.ReadLine();
            string s=cumle.Replace(" ",string.Empty);
            Console.Write("Cümledeki harf sayısı: "+ s.Length);
        }
    }
}
