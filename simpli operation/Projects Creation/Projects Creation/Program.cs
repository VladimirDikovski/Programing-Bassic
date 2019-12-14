using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());

            int workHour = project * 3;

            Console.WriteLine("The architect " + name +" will need "+workHour + " hours to complete "+ project + " project/s.");

        }
    }
}
