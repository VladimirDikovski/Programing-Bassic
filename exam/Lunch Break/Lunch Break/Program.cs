using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSerial = Console.ReadLine();
            double durationSerial = int.Parse(Console.ReadLine());
            double durationBreak = int.Parse(Console.ReadLine());

            double timeToLunch = durationBreak * 1 / 8;
            double timeToOtdih = durationBreak * 1 / 4;

            

            double ostatu4noVreme = durationBreak - timeToLunch- timeToOtdih;
            double diffrent = Math.Abs(ostatu4noVreme - durationSerial);
            if (ostatu4noVreme >= durationSerial)
            {
               
                Console.WriteLine($"You have enough time to watch {nameSerial} and left with {Math.Ceiling(diffrent)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSerial}, you need {Math.Ceiling(diffrent)} more minutes.");
            }

        }
    }
}
