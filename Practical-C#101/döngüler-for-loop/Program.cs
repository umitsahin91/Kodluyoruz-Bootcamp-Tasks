using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan değer aralığındaki tek sayıları yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)//burada tanımlanan "i" değişkenine sadece for içerisinde erişilebilir.
            {
                if(i%2==1)
                Console.WriteLine(i);

            }
            //1-1000 arasındaki çift ve tek sayıların toplamlarını ekrana yazdır
            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                    if(i%2==1)
                    tekToplam+=i;//tektoplam=tektoplam+i
                    else
                    ciftToplam+=i;//cifttoplam=cifttoplam+i 
                               
            }
            Console.WriteLine("Tek Sayılatın Toplamı : " +tekToplam);
            Console.WriteLine("Çift Sayıların Toplamı : "+ciftToplam);

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                break;//döngüyü sonlandırır.iç içe kullanılan for yapılarında kullanılan for döngüsünü sonlandırır.
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                continue;//uygun koşulda ara verir.
                Console.WriteLine(i);
            }

            for (;;)//sonsuz döngü
            {
                
            }

            
        }
    }
}
