using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    class DivisibleSumPairs
    {
        static void Main(string[] args)
        {
            List<int> parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = parameters[0];
            int k = parameters[1];
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 0;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                {
                    if ((numbers[i] + numbers[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
