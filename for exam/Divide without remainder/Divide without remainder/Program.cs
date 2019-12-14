using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double procent1 = 0;
            double procent2 = 0;
            double procent3 = 0;

            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (current % 2 == 0)
                {
                    p1++;
                }
                 if (current % 3 == 0)
                {
                    p2++;
                }
                 if (current % 4 == 0)
                {
                    p3++;
                }
            }

            procent1 = (p1 / n) * 100;
            procent2 = (p2 / n) * 100;
            procent3 = (p3 / n) * 100;
            Console.WriteLine($"{procent1:F2}%");
            Console.WriteLine($"{procent2:F2}%");
            Console.WriteLine($"{procent3:F2}%");


        }
    }
}
