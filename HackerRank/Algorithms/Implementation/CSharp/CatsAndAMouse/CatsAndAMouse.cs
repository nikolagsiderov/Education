using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsAndAMouse
{
    class CatsAndAMouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                int catA = inputParams[0];
                int catB = inputParams[1];
                int mouse = inputParams[2];

                int catASteps = Math.Abs(mouse - catA);
                int catBSteps = Math.Abs(mouse - catB);

                if (catASteps < catBSteps)
                {
                    Console.WriteLine("Cat A");
                }
                else if (catBSteps < catASteps)
                {
                    Console.WriteLine("Cat B");
                }
                else
                {
                    Console.WriteLine("Mouse C");
                }
            }
        }
    }
}
