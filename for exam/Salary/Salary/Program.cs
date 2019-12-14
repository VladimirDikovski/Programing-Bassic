using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int InternetTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool isSalaryOver = false;

            for (int i = 1; i <= InternetTabs; i++)
            {
                string webSits = Console.ReadLine();

                if (webSits == "Facebook")
                {
                    salary -= 150;
                }
                else if(webSits== "Instagram")  
                {
                    salary -= 100;
                }
                else if(webSits== "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    isSalaryOver = true;
                    break;
                }


            }

            if (isSalaryOver)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                int diff = Math.Abs(salary);
                Console.WriteLine(diff);
            }
        }
    }
}
