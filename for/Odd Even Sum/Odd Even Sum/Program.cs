using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumodd = 0;
            int sumEven = 0;

            for(int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += current;
                }
                else
                {
                    sumodd += current;
                }
            }

            if (sumEven == sumodd)
            {
                
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumodd}");
            }
            else
            {
                int dif = Math.Abs(sumEven - sumodd);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {dif}");
            }
        }
    }
}
