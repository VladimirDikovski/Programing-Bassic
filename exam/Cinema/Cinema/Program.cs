using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int sumOfBilets =0;
            bool IsCinemaFull = false;
            int sumPeople = 0;

            while (true)
            {
                string countPeople = Console.ReadLine();
                if(countPeople=="Movie time!")
                {
                    break;
                }
               

                int convertToInt = int.Parse(countPeople);
                sumPeople += convertToInt;
                if (sumPeople > capacity)
                {
                    IsCinemaFull = true;

                    break;
                }
                sumOfBilets += convertToInt * 5;
                if (convertToInt % 3 == 0)
                {
                    sumOfBilets-=5;
                }

               

            }


            if (IsCinemaFull)
            {
                Console.WriteLine("The cinema is full.");
                Console.WriteLine($"Cinema income - {sumOfBilets} lv.");
            }

            else
            {
                int ostanaliMesta = Math.Abs(sumPeople - capacity);
                Console.WriteLine($"There are {ostanaliMesta} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {sumOfBilets} lv.");
            }
        }
    }
}
