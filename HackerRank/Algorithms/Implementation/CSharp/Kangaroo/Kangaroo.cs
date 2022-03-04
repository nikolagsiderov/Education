using System;
using System.Collections.Generic;
using System.Linq;

namespace Kangaroo // Kind of solved... non case break
{
    class Kangaroo
    {
        static void Main(string[] args)
        {
            List<int> kangarooParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int startingPointFirstKangaroo = kangarooParameters[0];
            int speedFirstKangaroo = kangarooParameters[1];
            int startingPointSecondKangaroo = kangarooParameters[2];
            int speedSecondKangaroo = kangarooParameters[3];

            bool matching = false;

            if (speedFirstKangaroo <= speedSecondKangaroo)
            {
                Console.WriteLine("NO");
            }
            else
            {
                while (startingPointFirstKangaroo <= 90000000 && startingPointSecondKangaroo <= 90000000) // why 90000000?
                {
                    startingPointFirstKangaroo += speedFirstKangaroo;
                    startingPointSecondKangaroo += speedSecondKangaroo;

                    if (startingPointFirstKangaroo == startingPointSecondKangaroo)
                    {
                        matching = true;
                        break;
                    }
                }

                if (matching)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
