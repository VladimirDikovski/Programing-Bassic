using System;

namespace CircleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimetar = 2 * radius * Math.PI;
            double area = Math.PI * radius * radius;

            Console.WriteLine(area.ToString("0.00"));
            Console.WriteLine(perimetar.ToString("0.00"));
            

        }
    }
}
