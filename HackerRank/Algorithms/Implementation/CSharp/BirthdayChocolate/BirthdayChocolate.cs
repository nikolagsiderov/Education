using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChocolate
{
    class BirthdayChocolate
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> squares = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int d = parameters[0];
            int m = parameters[1];

            int count = 0;
            int countM = 0;
            int result = 0;
            int ways = 0;

            for (int i = 0; i < squares.Count; i++)
            {
                result += squares[i];
                count++;

                if (count == m)
                {
                    countM++;

                    if (result == d)
                    {
                        ways++;
                        count = 0;
                        result = 0;
                        i = countM - 1;
                    }
                    else
                    {
                        i = countM - 1;
                        result = 0;
                        count = 0;
                    }
                }
            }

            Console.WriteLine(ways);
        }
    }
}
