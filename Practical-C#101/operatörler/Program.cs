using System;

namespace operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama Ve İşlemli Atama
            Console.WriteLine("******** Atama Ve İşlemli Atama Operatörler *******");
            int x= 3;
            int y=3;
            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            // ||, &&,!
            Console.WriteLine("******** Mantıksal Operatörler *******");
            bool isSuccess = true;
            bool isComplated = false;
            if(isSuccess && isComplated)
            Console.WriteLine("Perfect");
            if(isSuccess||isComplated)
            Console.WriteLine("Greate");
            if(isSuccess||!isComplated)
            Console.WriteLine("Fine");

            //İlişkisel Operatörler
            //<,>,<=,>=,==,!=
            Console.WriteLine("******** İlişkisel Operatörler *******");
            int a =3;
            int b=4;
            bool sonuc=a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);
            //Aritmetik Operatörler
            //+, -, *, /
            Console.WriteLine("******** Aritmetik Operatörler *******");
            int sayi1 = 10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= ++sayi1;
            Console.WriteLine(sonuc1);

            //% : Mod almak için kullanılır.

            int sonuc2=20%3;
            Console.WriteLine(sonuc2);








            
        }
    }
}
