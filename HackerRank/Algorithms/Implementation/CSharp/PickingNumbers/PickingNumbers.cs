using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickingNumbers
{
    class PickingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            var subArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentIndexCounter = 1;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) <= 1)
                    {
                        currentIndexCounter++;
                    }
                }

                if (currentIndexCounter >= counter)
                {
                    counter = currentIndexCounter;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
