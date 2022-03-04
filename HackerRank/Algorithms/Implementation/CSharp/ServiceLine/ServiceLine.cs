using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLine
{
    class ServiceLine
    {
        static void Main(string[] args)
        {
            List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int testCases = inputParams[1];
            List<int> widths = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < testCases; i++)
            {
                List<int> indices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int startingIndex = indices[0];
                int endingIndex = indices[1];

                List<int> subWidths = new List<int>();

                for (int j = startingIndex; j <= endingIndex; j++)
                {
                    subWidths.Add(widths[j]);
                }

                Console.WriteLine(subWidths.Min());
            }
        }
    }
}
