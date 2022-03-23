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
            
           Console.Write("Short Edge : ");
           int sorthEdge=int.Parse(Console.ReadLine());
           Console.Write("Long Edge : ");
           int longEdge=int.Parse(Console.ReadLine());

           Console.WriteLine($"Rectangel Contour : {(sorthEdge*2)+(longEdge*2)}");
           Console.WriteLine($"Rectangel Area : {sorthEdge*longEdge}");
        }
    }
}
