using System;

namespace _12._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacantionPrice = double.Parse(Console.ReadLine());
            int puzzelCount = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int tadyBeert = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truskCount = int.Parse(Console.ReadLine());

            double toyCount = puzzelCount + dolls + tadyBeert + minions + truskCount;
            double toyPrice = (puzzelCount * 2.60) + (dolls * 3) + (tadyBeert * 4.10) + (minions * 8.20) +
            (truskCount * 2);


            if (toyCount >= 50)
            {
                toyPrice = toyPrice * 0.75;
            }
            toyPrice = toyPrice * 0.90;

            if (toyPrice >= vacantionPrice)
            {
                Console.WriteLine("Yes! {0:F2} lv left. ", toyPrice - vacantionPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", vacantionPrice - toyPrice);
            }




        }
    }
}