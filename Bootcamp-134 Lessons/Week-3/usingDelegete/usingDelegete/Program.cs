using System;
using System.Collections.Generic;
using System.Linq;

namespace usingDelegete
{
    class Program
    {
        static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        static void Main(string[] args)
        {
            /*
             * yukarıdaki numbers isimli array içindeki sayıalrı programcının dilediği gibi filtrelemesini istiyoruz
             */

            //.NET 1.0
            //var filtered = Filters.Filter(numbers, isMultiply3);

            //.NET 2.0
            //var filtered = Filters.Filter(numbers, delegate (int c) { return c < 5; });

            //.NET 3.5
            var filters = Filters.Filter(numbers, x => x < 5);


            //foreach (var item in filters)
            //{
            //    Console.WriteLine(item);
            //}

            filters.ForEach(p => Console.WriteLine(p));

            filters.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
            
        }

        static bool isEven(int item)
        {
            return item % 2 == 0;
        }

        static bool isMultiply3(int item)
        {
            return item % 3 == 0;
        }
    }
}
