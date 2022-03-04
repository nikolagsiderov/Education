using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class MarsExploration
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int countFirstLetter = 0;
            int countSecondLetter = 0;
            int countThirdLetter = 0;

            for (int i = 0; i < message.Length; i+=3)
            {
                if (message[i] != 'S')
                {
                    countFirstLetter++;
                }
            }

            for (int i = 1; i < message.Length; i+=3)
            {
                if (message[i] != 'O')
                {
                    countSecondLetter++;
                }
            }

            for (int i = 2; i < message.Length; i+=3)
            {
                if (message[i] != 'S')
                {
                    countThirdLetter++;
                }
            }

            Console.WriteLine(countFirstLetter+countSecondLetter+countThirdLetter);
        }
    }
}
