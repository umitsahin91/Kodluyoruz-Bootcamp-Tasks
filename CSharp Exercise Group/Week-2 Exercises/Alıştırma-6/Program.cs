using System;

namespace alıştırma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int teksayi=0;
            int ciftsayi=0;
            for (int i = 0; i < 10; i++)
            {
                Random random =new Random();
                if (random.Next()%2==0)
                {
                    ciftsayi++;
                }
                else
                {
                    teksayi++;
                }
                
            }
            Console.WriteLine("Çift sayıların sayısı : "+ciftsayi);
            Console.WriteLine("Tek sayıların sayısı : "+teksayi);
        }
    }
}
