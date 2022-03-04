using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDaysAtTheMovies
{
    class BeautifulDaysAtTheMovies
    {
        static void Main(string[] args)
        {
            List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int startingDate = inputParams[0];
            int endingDate = inputParams[1];
            int numberToDivise = inputParams[2];

            int count = 0;

            for (int i = startingDate; i <= endingDate; i++)
            {
                int reversed = GetReversed(i);

                int difference = Math.Abs(i - reversed);

                if (difference % numberToDivise == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static int GetReversed(int i)
        {
            int reverse = 0;
            while (i > 0)
            {
                int remainder = i % 10;
                reverse = (reverse * 10) + remainder;
                i = i / 10;
            }

            return reverse;
        }
    }
}
