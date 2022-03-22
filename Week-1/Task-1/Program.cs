using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Program that calculates the area and perimeter of a rectangle and displays it on the screen.
            */
           System.Console.Write("Short Ledge : ");
           int sorthLedge=int.Parse(Console.ReadLine());
           System.Console.Write("Long Ledge : ");
           int longLedge=int.Parse(Console.ReadLine());

           System.Console.WriteLine($"Rectangel Contour : {(sorthLedge*2)+(longLedge*2)}");
           System.Console.WriteLine($"Rectangel Area : {sorthLedge*longLedge}");
        }
    }
}
