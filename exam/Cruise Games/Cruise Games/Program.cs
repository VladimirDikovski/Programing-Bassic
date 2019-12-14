using System;

namespace Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            
            
            double tenisgame = 0;
            double voleyballGame = 0;
            double badmintonGame = 0;
            double average1 = 0;
            double average2 = 0;
            double average3 = 0;
            double result1 = 0;
            double result2 = 0;
            double result3 = 0;
            double resultAll = 0;

            for (int i = 0; i < games; i++)
            {
                string typeGame = Console.ReadLine();
                double point = int.Parse(Console.ReadLine());

                if(typeGame== "volleyball")
                {
                    voleyballGame++;
                    point += 0.07 * point;
                    result1 +=point;
                   
                    average1 =Math.Floor(result1 / voleyballGame);
                    

                }

                else if (typeGame =="tennis")
                {
                    tenisgame++;
                    point += 0.05*point;
                    result2 +=point;
                  
                    average2 =  Math.Floor(result2 / tenisgame);

                }

                else
                {
                    badmintonGame++;
                    point += 0.02*point;
                    result3 += point;
                    average3 = Math.Floor(result3 / badmintonGame);

                }
                 
            }
            resultAll = Math.Floor(result1 + result2 + result3);

            if (average1 >= 75 && average2 >= 75 && average3 >= 75)
            {
                Console.WriteLine($"Congratulations, {name}! You won the cruise games with {resultAll} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {name}, you lost. Your points are only {resultAll}.");
            }
        }
    }
}
