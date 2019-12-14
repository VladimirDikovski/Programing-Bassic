using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());


            for(int i = a; i <= b; i++)
            {
               for(int j = a; j <= b; j++)
                {
                    for(int m = c; m <= d; m++)
                    {
                        for (int n = c; n <= d; n++)
                        {
                            if(i+n == m+j) 
                            {
                                if(i != j && m!= n)
                                {
                                    Console.WriteLine($"{i} {j} ");
                                    Console.WriteLine($"{m} {j}");
                                    Console.WriteLine();
                                }
                                
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
