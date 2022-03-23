using System;

namespace alıştırma_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metin girin : ");
            string metin =Console.ReadLine();
            Console.Write("Tekrar sayısını girin : ");
            int tekrar =int.Parse(Console.ReadLine());
            for (int i = 0; i < tekrar; i++)
            {
                Console.WriteLine(metin);
            }
        }
    }
}
