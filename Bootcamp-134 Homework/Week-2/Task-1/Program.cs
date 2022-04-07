using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
          List<string> cities= new List<string>{"Ankara","Trabzon","Bursa","Adana","Kastamonu","Ankara","Trabzon","Bursa","Adana","Kastamonu"};
          List<string> distinctCities= new List<string>();
          foreach (var city in cities)
          {
              if (!distinctCities.Contains(city))
              {
                  distinctCities.Add(city);
              }    
          }      
        }
    }
}
