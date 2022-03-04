using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class CountingValleys
    {
        static void Main(string[] args)
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            List<char> steps = Console.ReadLine().ToList();
            int seaLevel = 0;
            int valleys = 0;
            int lastSeaLevel = 0;

            for (int i = 0; i < steps.Count; i++)
            {
                lastSeaLevel = seaLevel;

                switch (steps[i])
                {
                    case 'D':
                        seaLevel--;
                        break;
                    case 'U':
                        seaLevel++;
                        break;
                }

                if (seaLevel == 0)
                {
                    if (lastSeaLevel < 0)
                    {
                        valleys++;
                    }
                }
            }

            Console.WriteLine(valleys);
        }
    }
}
