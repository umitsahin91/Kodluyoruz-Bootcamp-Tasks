using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Girilen string ifadede boşluk karakterine kadar olan kısmı yazdıran
            program.(Örnek: Kodluyoruz’da yer alan bootcamp’lere başvuracağım cümlesi
            girildiğinde ekrana sadece Kodluyoruz’da yazdırılması gerekir.)
            */
            string text="Kodluyoruz’da yer alan bootcamp’lere başvuracağım";
            int index=text.IndexOf(" ");
            Console.Write(text.Substring(0,index));

        }
    }
}
