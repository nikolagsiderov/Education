using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class AVeryBigSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            Console.WriteLine(numbers.Sum());
        }
    }
}
