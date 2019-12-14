using System;

namespace convertFromBullToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();
            int lenght = digit.Length;
            int counter = 0;
            double umn = 0;
            double sum = 0;
            if (lenght > 8)
            {
                Console.WriteLine("PLS ENTER A VALID 8 BIT NUMBER ");
            }

            else
            {
                for (int i = lenght; i > 0; i--)
                {


                    char b = digit[i - 1];

                    if (b == '1')
                    {

                        umn = Math.Pow(2, counter);

                        sum += umn;
                    }
                    counter++;
                }
                

            }

            
            Console.WriteLine(sum);
           
        }
    }
}
