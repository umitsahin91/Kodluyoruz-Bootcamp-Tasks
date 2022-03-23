using System;

namespace Alıştırma_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa Kenar: ");
            int kısaKenar= int.Parse(Console.ReadLine());
            Console.Write("Uzun Kenar: ");
            int uzunKenar=int.Parse(Console.ReadLine());
            Console.Write("Alan: "+(kısaKenar*uzunKenar+"\n"));
            Console.Write("Çevre: "+((kısaKenar*2)+(uzunKenar*2)));
        }
    }
}
