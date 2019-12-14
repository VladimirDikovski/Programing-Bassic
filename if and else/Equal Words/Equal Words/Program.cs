using System;

namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().ToLower();

            string name2 = Console.ReadLine().ToLower();
            

            if (name == name2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
