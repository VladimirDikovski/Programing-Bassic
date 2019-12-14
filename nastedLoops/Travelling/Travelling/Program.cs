using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();


            double savedMoney = 0;
            double sum = 0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                sum = 0;


                while (sum < budget)
                {
                    savedMoney = double.Parse(Console.ReadLine());

                    sum += savedMoney;

                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();


            }
        }
    }
}
