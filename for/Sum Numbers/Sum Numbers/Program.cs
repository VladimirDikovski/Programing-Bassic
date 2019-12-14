using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;

            for(int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                result += digit;

            }
            Console.WriteLine(result);
        }
    }
}
