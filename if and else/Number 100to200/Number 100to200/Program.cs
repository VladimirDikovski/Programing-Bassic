using System;

namespace Number_100to200
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());

            if (digit < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if(digit>=100 && digit <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }

            else if (digit > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
