using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumDistances
{
    class MinimumDistances
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> arr = Console.ReadLine().Split(' ').ToList();

            int minDistance = int.MaxValue;

            for (int i = 0; i < arr.Count; i++)
            {
                if (i == arr.Count - 1)
                {
                    break;
                }

                for (int j = i+1; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (j - i <= minDistance)
                        {
                            minDistance = j - i;
                        }
                    }
                }
            }


            if (minDistance == int.MaxValue)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(minDistance);
            }
        }
    }
}
