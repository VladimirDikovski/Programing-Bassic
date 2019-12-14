using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int sumName = 0;
            int maxValue = int.MinValue;
            string winnerName = string.Empty;

            while (name != "STOP")
           {

                for (int i = 0; i < name.Length; i++)
                {
                    sumName += name[i];
                   
                }
                if (sumName > maxValue)
                {
                    maxValue = sumName;
                    winnerName = name;

                }
                sumName = 0;
                name = Console.ReadLine();
               
            }
            Console.WriteLine($"Winner is {winnerName} - {maxValue}!");

        }
    }
}
