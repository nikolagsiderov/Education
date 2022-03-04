using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCharacters
{
    class AlternatingCharacters // unsolved 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string sequenceOfChars = Console.ReadLine();
                int deletion = 0;

                char firstChar = sequenceOfChars[0];

                for (int j = 0; j < sequenceOfChars.Length; j++)
                {

                }

                Console.WriteLine(deletion);
            }
        }
    }
}
