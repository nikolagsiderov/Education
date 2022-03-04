using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class CompareTheTriplets
    {
        static void Main(string[] args)
        {
            int[] Alice = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] Bob = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int alicePoints = 0;
            int bobPoints = 0;

            for (int i = 0; i < Alice.Length; i++)
            {
                if (Alice[i] > Bob[i])
                {
                    alicePoints++;
                }
                else if (Bob[i] > Alice[i])
                {
                    bobPoints++;
                }
            }

            Console.WriteLine(alicePoints + " " + bobPoints);
        }
    }
}
