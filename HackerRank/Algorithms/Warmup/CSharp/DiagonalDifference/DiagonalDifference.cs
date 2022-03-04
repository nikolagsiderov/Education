using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference // I have to learn how to solve this problem with matrices
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                firstDiagonalSum += line[i];
                secondDiagonalSum += line[line.Length - i - 1];
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
