using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double lv = double.Parse(Console.ReadLine());
            double dolar =  1.79549;

            double result = lv * dolar;

            Console.WriteLine(result.ToString("0.00"));
                

        }
    }
}
