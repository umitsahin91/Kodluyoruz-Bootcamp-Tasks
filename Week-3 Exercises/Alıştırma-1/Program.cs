using System;


namespace Alıştırma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCounter wc = new WordCounter();
            Console.Write("Lütfen metni giriniz : ");
            string[] text=wc.Split(Console.ReadLine());

            Console.WriteLine(wc.Counter(text));

            
        }
    }


class WordCounter
{
    public string[] Split (string text)
    {

        string[] _text=text.Split(' ');
        return _text;     
    }

    public int Counter(string[] text)
    {
        int counter=0;
       
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i]=="")
            {
                counter++;
            }
        }

        return text.Length-counter;
    }
    
}


}
