using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            double procent1 = 0;
            double procent2 = 0;
            double procent3 = 0;
            double procent4 = 0;
            double procent5 = 0;
           





            for (int i = 1; i <= n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current < 200)
                {
                    p1++;
                }
                else if (current >= 200 && current <= 399)
                {
                    p2++;
                }
                else if (current >= 400 && current <= 599)
                {
                    p3++;
                }
                else if (current>=600 && current <= 799)
                {
                    p4++;
                }
                else if (current >= 800)
                {
                    p5++;
                }
            }

            procent1 = (p1 / n) * 100;
            procent2 = (p2 / n) * 100;
            procent3 = (p3 / n) * 100;
            procent4 = (p4 / n) * 100;
            procent5 = (p5 / n) * 100;
            Console.WriteLine($"{procent1:f2}%");
            Console.WriteLine($"{procent2:f2}%");
            Console.WriteLine($"{procent3:f2}%");
            Console.WriteLine($"{procent4:f2}%");
            Console.WriteLine($"{procent5:f2}%");



        }
    }
}
