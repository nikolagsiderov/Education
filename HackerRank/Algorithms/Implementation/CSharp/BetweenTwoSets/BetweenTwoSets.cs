using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets // solved
{
    class BetweenTwoSets
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> setA = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();

            List<int> setB = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();

            HashSet<int> factors = new HashSet<int>();

            bool notDivideable = false;
            int counter = 0;

            for (int k = setA.Count - 1; k >= 0; k--)
            {
                int lastValueOfA = setA[k];

                while (lastValueOfA <= setB[0])
                {
                    for (int i = setA.Count - 1; i >= 0; i--)
                    {
                        if (lastValueOfA % setA[i] != 0)
                        {
                            notDivideable = true;

                            break;
                        }
                    }

                    for (int i = 0; i < setB.Count; i++)
                    {
                        if (setB[i] % lastValueOfA != 0)
                        {
                            notDivideable = true;

                            break;
                        }
                    }

                    if (!notDivideable)
                    {
                        if (!factors.Contains(lastValueOfA))
                        {
                            factors.Add(lastValueOfA);
                            counter++;
                        }
                    }

                    lastValueOfA++;
                    notDivideable = false;
                }
            }


            Console.WriteLine(counter);
        }
    }
}
