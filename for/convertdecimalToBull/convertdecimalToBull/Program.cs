using System;

namespace convertdecimalToBull
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double n = int.Parse(Console.ReadLine());
            double result = 0;
           
            while (n != 0)
            {
                result = n / 2;
                Console.WriteLine(result);
            }
        }
    }
}
