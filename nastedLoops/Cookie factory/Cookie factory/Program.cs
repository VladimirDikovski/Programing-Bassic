using System;

namespace Cookie_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool ishaveSugar = false;
            bool ishaveEggs = false;
            bool ishaveFloar = false;

          for(int i = 1; i <=n; i++)
            {
               
                while (true)
                {
                    string products = Console.ReadLine();
                    if (products == "Bake!")
                    {
                        break;
                    }
                    if (products == "flour")
                    {
                        ishaveFloar = true;
                    }
                    else if (products == "eggs")
                    {
                        ishaveEggs = true;
                    }
                    else if (products == "sugar")
                    {
                        ishaveSugar = true;
                    }
                    
                }
                if (ishaveSugar && ishaveEggs && ishaveFloar)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    ishaveFloar = false;
                    ishaveEggs = false;
                    ishaveSugar = false;
                }
                else
                {
                    i--;
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }





            }
        }
    }
}
