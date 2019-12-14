using System;

namespace Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket = int.Parse(Console.ReadLine());


            for (int i = 0; i < ticket; i++)
            {
                string biletType = Console.ReadLine();
                int stringLenght = biletType.Length;

                if (stringLenght >= 5)
                {
                    Console.WriteLine( $"Seat decoded: {biletType[0]}{(int)biletType[1]}");
                }

                  
                   else if ((int)biletType[0]>=65 && (int)biletType[0] <= 90)
                    {
                        
                        Console.WriteLine($"Seat decoded: {biletType[0]}{biletType[1]}{biletType[2]}");
                    }
                    
                  
                 else 
                 {
                    Console.WriteLine($"Seat decoded: {biletType[3]}{biletType[1]}{biletType[2]}");
                 }
                    

            }

        }
    }
}
