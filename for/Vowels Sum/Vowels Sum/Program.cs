using System;

namespace Vowels_Sum
{
    class Program
    {

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int summ = 0;

            for(int i = 0; i < word.Length; i++)
            {
                char b = word[i];
                if (b == 'a')
                {
                    summ += 1;
                }
                else if (b == 'e')
                {
                    summ += 2;
                }
                else if (b == 'i')
                {
                    summ += 3;

                }
                else if(b== 'o')
                {
                    summ += 4;

                }
                else if (b== 'u')
                {
                    summ += 5;
                }

            }
            Console.WriteLine(summ);
        }
    }
}
