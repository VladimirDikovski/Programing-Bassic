using System;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int sum = 0;
            int diff = 0;
            int maxDiff = int.MinValue;
            
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            sum = number1 + number2;
            int previusSum = sum;

            for (int i = 1; i < n; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                sum = number1 + number2;
                if (sum == previusSum)
                {
                    diff = Math.Abs(sum - previusSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }

                    
                }

            }
            if (maxDiff == 0)
            {

            }
        }
    }
}
