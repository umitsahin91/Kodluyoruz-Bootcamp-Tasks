using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim

            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int diziUzunluk=int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int[diziUzunluk];

            for (int i = 0; i < diziUzunluk; i++)
            {
                Console.Write("Lütfen {0}.sayıyı girin : ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());   
            }
            int toplam =0;
            foreach (int sayi in sayiDizisi)
            {
                toplam+=sayi;
                
            }
            Console.WriteLine("Ortalama : "+toplam/diziUzunluk);




        }
    }
}
