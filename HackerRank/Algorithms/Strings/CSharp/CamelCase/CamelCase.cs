using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class CamelCase
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 65 && input[i] <= 90)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter+1);
        }
    }
}
