﻿using System;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double result = inch * 2.54;
           
            Console.WriteLine(result.ToString("0.00"));
        }
    }
}
