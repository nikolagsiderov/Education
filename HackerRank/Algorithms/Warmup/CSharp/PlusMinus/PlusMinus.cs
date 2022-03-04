using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class PlusMinus
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double positivesCount = 0;
            double negativesCount = 0;
            double zeroesCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    positivesCount++;
                }
                else if (numbers[i] < 0)
                {
                    negativesCount++;
                }
                else
                {
                    zeroesCount++;
                }
            }

            Console.WriteLine("{0:f6}", positivesCount/numbers.Count());
            Console.WriteLine("{0:f6}", negativesCount/numbers.Count());
            Console.WriteLine("{0:f6}", zeroesCount/numbers.Count());
        }
    }
}
