using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int diff = 0;
            int leftSum = 0;
            int rightSum = 0;

            for(int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                leftSum += current;
            }

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                rightSum += current;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum}");
            }
            else
            {
                diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }

        
    }
}
