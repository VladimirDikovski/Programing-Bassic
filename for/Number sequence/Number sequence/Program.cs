using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxInteger = int.MinValue;
            int minInteger = int.MaxValue;

            for(int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > maxInteger)
                {
                    maxInteger = current;
                }

                if (current < minInteger)
                {
                    minInteger = current;
                }
            }
            Console.WriteLine($"Max number: {maxInteger}");
            Console.WriteLine($"Min number: {minInteger}");
        }
    }
}
