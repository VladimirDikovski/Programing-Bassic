using System;

namespace RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double degrees = radius * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
