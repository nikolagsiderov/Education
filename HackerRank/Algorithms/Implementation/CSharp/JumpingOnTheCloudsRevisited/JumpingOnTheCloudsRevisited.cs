using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheCloudsRevisited
{
    class JumpingOnTheCloudsRevisited
    {
        static void Main(string[] args)
        {
            List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> cloudParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int jump = inputParams[1];
            int energy = 100;
            int currentCloud = -1;
            bool first = false;

            while (currentCloud != 0)
            {

            }

            Console.WriteLine(energy);
        }
    }
}
