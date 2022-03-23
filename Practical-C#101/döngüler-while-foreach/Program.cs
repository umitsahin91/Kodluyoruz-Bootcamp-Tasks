using System;

namespace döngüler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****WHİLE*****");
            //while
            //1 den başlayarak console dan alınan sayıya kadar (sayı dahil) ortalamasını hesaplayıp console a yazdıran program
            Console.Write("Lütfen bir sayı giriniz : ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.Write("Ortalama : "+toplam/sayi+"\n");

            //a'dan z'ye kadar tüm harfleri console a yazdır

            char karakter='a';
            Console.Write("Harfler : ");
            while (karakter<'z')
            {
                Console.Write(karakter);
                karakter++;
            }
            //Foreach
            Console.WriteLine("\n"+"*****FOREACH*****");
            string[]arabalar={"BMW","FORD","TOYOTA","NISSAN"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
