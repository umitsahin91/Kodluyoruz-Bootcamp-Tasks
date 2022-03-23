using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
            Derece olarak verilen sıcaklığı Fahrenheita çeviren program
            */
            Console.Write("Derece değerini girin  : ");
            int celcius=int.Parse(Console.ReadLine());
            int fahrenheit=(celcius*9/5)+32;
            Console.Write($"Girmiş olduğunuz derecenin Fahrenheit karşılığı : {fahrenheit}");
    }
}
