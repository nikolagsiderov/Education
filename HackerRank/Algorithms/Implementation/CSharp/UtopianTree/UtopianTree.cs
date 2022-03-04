using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopianTree
{
    class UtopianTree
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int height = 1;

                int cycles = int.Parse(Console.ReadLine());

                for (int j = 1; j <= cycles; j++)
                {
                    if (j % 2 != 0)
                    {
                        height *= 2;
                    }
                    else
                    {
                        height++;
                    }
                }

                Console.WriteLine(height);
            }
        }
    }
}
