using System;

namespace OddorEven_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double oddSum = 0;
            double EvenSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            bool isEvenEmpty = false;
            bool isOddEmpty = false;


            for(int i = 1; i <= n; i++)
            {
                double current = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    isEvenEmpty = true;
                    EvenSum += current;
                    if (current > evenMax)
                    {
                        evenMax = current;
                    }
                    if (current < evenMin)
                    {
                        evenMin = current; 
                    }
                }
                else
                {
                    isOddEmpty = true;
                    oddSum += current;
                    if (current > oddMax)
                    {
                        oddMax = current;
                    }
                    if (current < oddMin)
                    {
                        oddMin = current;

                    }
                }

            }
            Console.WriteLine($"OddSum={oddSum:F2},");
            if (isOddEmpty)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else if (isOddEmpty == false)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            
            Console.WriteLine($"EvenSum={EvenSum:F2},");
            if (isEvenEmpty)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else if(isEvenEmpty==false)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            

        }
    }
}
