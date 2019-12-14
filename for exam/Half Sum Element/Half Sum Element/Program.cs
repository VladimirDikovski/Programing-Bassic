using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;
            int sum = 0;
            int difrenc = 0;

            for(int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxValue)
                {
                    maxValue = currentNumber;
                }

                sum += currentNumber;

            }
            difrenc = sum - maxValue;
            if (difrenc == maxValue)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxValue}");
            }
            else
            {
                int diff = Math.Abs(maxValue - difrenc);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");

            }

        }
    }
}
