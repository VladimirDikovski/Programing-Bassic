using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double kvm = double.Parse(Console.ReadLine());

            double pricekvm = 7.61;

            double result = kvm * pricekvm;
            double endPrice = result * 0.18;
            double otstupka = Math.Abs(endPrice - result);

            Console.WriteLine("The final price is: " + otstupka.ToString("0.00") + " lv.");
            Console.WriteLine("The discount is: " + endPrice.ToString("0.00") + " lv.");
           
        }
    }
}
