using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string figure = Console.ReadLine();
            if(figure== "square")
            {
                double sideSquera = double.Parse(Console.ReadLine());
                result = sideSquera * sideSquera;
                Console.WriteLine(result.ToString("0.000"));
            }

            if(figure== "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a * b;
                Console.WriteLine(result.ToString("0.000"));

            }

            if(figure== "circle")
            {
                double r  = double.Parse(Console.ReadLine());
                result = Math.PI * r * r;
                Console.WriteLine(result.ToString("0.000"));
            }

            if(figure== "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                result = a * h / 2;
                Console.WriteLine(result.ToString("0.000"));
            }
        }
    }
}
