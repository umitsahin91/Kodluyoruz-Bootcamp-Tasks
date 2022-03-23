using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Klavyeden girilen metnin kaç kelimeden oluştuğunu bulan program.
            */
            WordCounter wc = new WordCounter();
            Console.Write("Lütfen metni giriniz : ");
            string[] text = wc.Split(Console.ReadLine());

            Console.WriteLine(wc.Counter(text));
        }
    }
    class WordCounter
    {
        /*
        Girilen metni split metotu ile string diziye dönüştüren metot.
        */
        public string[] Split(string text)
        {

            string[] _text = text.Split(' ');
            return _text;
        }
        /*
        Gönderilen dizinin içerisinde ki boşlukların kontrolü yapılıp
        geriye kelime sayısı döndürülüyor.
        */
        public int Counter(string[] text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == "")
                {
                    counter++;
                }
            }

            return text.Length - counter;
        }

    }
}
