using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int DogCount = int.Parse(Console.ReadLine());
            int otherPet = int.Parse(Console.ReadLine());
            
            

            double resultDog = DogCount * 2.5;
            double resultOther = otherPet * 4.0;

            double sum = resultDog + resultOther;

            Console.WriteLine(sum.ToString("0.00")+" lv.");

         

        }
    }
}
