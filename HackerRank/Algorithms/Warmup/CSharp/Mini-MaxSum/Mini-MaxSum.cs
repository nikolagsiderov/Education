using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> copy = numbers.ToList();

            numbers.Remove(numbers.Max());

            long minSum = numbers.Sum();

            copy.Remove(copy.Min());

            long maxSum = copy.Sum();

            Console.WriteLine(minSum + " " + maxSum);

        }
    }
}
