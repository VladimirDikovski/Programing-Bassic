using System;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double viso4ina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double duljina = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double value = viso4ina * shirina * duljina;
            double valueWater = value * 0.001;
            double procentConvector = procent * 0.01;
            double result = valueWater * (1 - procentConvector);
            Console.WriteLine(result.ToString("0.000"));

        }
    }
}
