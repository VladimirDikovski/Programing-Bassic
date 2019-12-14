using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter heith");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter witgh");
            double b = double.Parse(Console.ReadLine());
            double result = a * b;
            Console.WriteLine("your result is "+result);
        }
    }
}
