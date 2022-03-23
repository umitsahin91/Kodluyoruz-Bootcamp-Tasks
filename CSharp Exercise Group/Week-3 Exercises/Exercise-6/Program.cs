using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Verilen bir kişi adını bir dizide arayan ve bulunup bulunamadığını belirten
            program. (Diziyi siz girebilirsiniz ya da kullanıcıdan alabilirsiniz.)
            */
            Console.Write("Lütfen Kişi Sayısını Girin : ");
            int number = int.Parse(Console.ReadLine());
            List list = new List(number);
            list.Listing();
            Console.Write("Lütfen Aranan Kişiyi Girin : ");
            string searching=Console.ReadLine();
            bool check =list.Searching(searching);
            list.Checked(check);           
        }
    }
      class List
        {
            string[] list;
            int number;

            public List(int number)
            {
                this.number = number;
                list = new string[number];
            }
            public void Listing()
            {

                for (int i = 0; i < number; i++)
                {
                    Console.Write($"Lütfen {i+1}.Kişiyi Girin : ");
                    list[i] = Console.ReadLine();
                    
                }
            }

            public bool Searching(string searching)
            {
                int counter=0;
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i]==searching)
                    {
                       counter++; 
                    }
                }
                if(counter>0)
                    return true;
                else
                    return false;
                
            }

            public void Checked(bool check)
            {
                if(check)
                    Console.Write("Aranan kişi listede var");
                else
                    Console.Write("Aradığınız kişi listede yok");

            }
        }


}
