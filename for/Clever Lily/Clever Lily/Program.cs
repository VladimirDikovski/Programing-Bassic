using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashMachine =double.Parse(Console.ReadLine());
            int PriceToy = int.Parse(Console.ReadLine());
            int toy = 0;
            int moneyFromBritday = 0;
            int counterMoney = 1;
            double diff = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toy++;
                }

                else
                {
                    moneyFromBritday += (10*counterMoney)-1;
                    counterMoney++;
                }
            }
            double allmoney = moneyFromBritday + (toy * PriceToy);
          
            if (allmoney >= priceWashMachine)
            {
                diff = Math.Abs(allmoney - priceWashMachine);
                Console.WriteLine($"Yes! {diff:f2}");
             
            }
            else
            {
                diff = Math.Abs(allmoney - priceWashMachine);
                Console.WriteLine($"No! {diff:f2}");
            }
        }
    }
}
