using System;

namespace Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            int countSealson = int.Parse(Console.ReadLine());
            int countEpizod = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double reklama = time * 0.20;
            double totalTime = time + reklama;
            int specialTime = countSealson * 10;
            double alltime = totalTime * countEpizod *countSealson + specialTime;
            Console.WriteLine($"Total time needed to watch the {nameSerial} series is {(int)alltime} minutes.");



        }
    }
}
