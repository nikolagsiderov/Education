using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHurdleRace
{
    class TheHurdleRace
    {
        static void Main(string[] args)
        {
            List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> hurdles = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int danMaxJump = inputParams[1];
            int maxHurdle = hurdles.Max();

            if (danMaxJump >= maxHurdle)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(maxHurdle-danMaxJump);
            }
        }
    }
}
