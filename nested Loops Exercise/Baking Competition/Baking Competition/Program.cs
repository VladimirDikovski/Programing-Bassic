using System;

namespace Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            double players = int.Parse(Console.ReadLine());
            double sladki = 0;
            double torti = 0;
            double gofreti = 0;
            double result = 0;
            double allbakeSold = 0;

            int counterSweet = 0;

            for(int i = 1; i <= players; i++)
            {
                string name = Console.ReadLine();
                
                while (true)
                {
                    string type = Console.ReadLine();
                    if(type== "Stop baking!")
                    {
                       
                        break;
                    }
                    int count = int.Parse(Console.ReadLine());
                    counterSweet += count;
                    if(type== "cookies")
                    {
                        sladki+=count;
                        
                    }
                     else if (type == "cakes")
                    {
                        torti+=count;
                        
                    else 
                    {
                        gofreti+=count;
                        
                    }
                   
                }
                Console.WriteLine($"{name} baked {sladki} cookies, {torti} cakes and {gofreti} waffles.");
                torti = 0;
                sladki = 0;
                gofreti = 0;


            }

                allbakeSold = counterSweet;
            result = ((torti * 1.50) + (sladki * 7.80) + (gofreti * 2.30));

            Console.WriteLine($"All bakery sold: {allbakeSold}");
            Console.WriteLine($"Total sum for charity: {result:F2} lv.");

            

        }
    }
}
