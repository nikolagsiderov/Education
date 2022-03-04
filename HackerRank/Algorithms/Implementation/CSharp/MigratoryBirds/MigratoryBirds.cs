using System;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    class MigratoryBirds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> birdTypes = Console.ReadLine().Split(' ').ToList();

            int count = 1;
            Dictionary<string, int> typesCount = new Dictionary<string, int>();

            for (int i = 0; i < birdTypes.Count; i++)
            {
                if (typesCount.Keys.Contains(birdTypes[i]))
                {
                    continue;
                }
                else
                {
                    typesCount[birdTypes[i]] = 1;
                }

                if (i == birdTypes.Count-1)
                {
                    break;
                }

                for (int j = i+1; j < birdTypes.Count; j++)
                {
                    if (birdTypes[i] == birdTypes[j])
                    {
                        typesCount[birdTypes[i]]++;
                    }
                }
            }

            Console.WriteLine(typesCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First().Key);
        }
    }
}
