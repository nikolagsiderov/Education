using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class BirthdayCakeCandles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> heights = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            heights = heights.OrderByDescending(x => x).ToList();

            int count = 1;

            for (int i = 0; i < heights.Count-1; i++)
            {
                if (heights[i+1] != heights[i])
                {
                    break;
                }

                count++;
            }

            Console.WriteLine(count);
        }
    }
}
