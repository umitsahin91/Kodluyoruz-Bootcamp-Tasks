using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time=DateTime.Now.Hour;
            if(time>=6&&time<11)
            {
                Console.WriteLine("İyi günler");
            }
            else if(time<=18&&time>11)
            {
                Console.WriteLine("İyi günler");

            }
            else{
                Console.WriteLine("İyi geceler");
            }

            string sonuc = time<=18?"İyi günler":"İyi geceler";

            string sonuc2= time>=6&&time<=11?"Günaydın":time<=18&&time>11?"İyi günler":"İyigeceler";
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);

        }
    }
}
