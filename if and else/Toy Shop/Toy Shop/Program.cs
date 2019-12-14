using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            double endPrice = 0;
            double naem = 0;
            double Pechalba = 0;
            double result = 0;
            double priceAdvanture = double.Parse(Console.ReadLine());
            int countPuzzle = int.Parse(Console.ReadLine());
            int Countdoll = int.Parse(Console.ReadLine());
            int Countbear = int.Parse(Console.ReadLine());
            int CountMinions = int.Parse(Console.ReadLine());
            int CountTrucks= int.Parse(Console.ReadLine());

            double summOrders = countPuzzle * 2.60 + Countdoll * 3 + Countbear * 4.10 + CountMinions * 8.20 + CountTrucks * 2;
            int countToys = countPuzzle + Countdoll + Countbear + CountMinions + CountTrucks;
            if (countToys >= 50)
            {
              discount= summOrders*0.25;
            }

             endPrice = Math.Abs(summOrders - discount);
            naem = endPrice * 0.10;

            Pechalba = Math.Abs(endPrice - naem);

            if (Pechalba >= priceAdvanture)
            {
                result = Math.Abs(Pechalba - priceAdvanture);
                Console.WriteLine("Yes! " + result.ToString("0.00") + " lv left.");
            }

            else
            {
                result = Math.Abs(Pechalba - priceAdvanture);
                Console.WriteLine("Not enough money! " + result.ToString("0.00") + " lv needed.");
            }

            
        }
    }
}
