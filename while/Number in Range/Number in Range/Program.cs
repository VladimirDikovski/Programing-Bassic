using System;

namespace Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            while (digit < 1 || digit > 100)
            {
                Console.WriteLine("Invalid number!");
                digit = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("The number is: " + digit);
        }
    }
}
