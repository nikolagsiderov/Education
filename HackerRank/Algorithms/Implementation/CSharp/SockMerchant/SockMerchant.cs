using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class SockMerchant
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> looseSocks = Console.ReadLine().Split(' ').ToList();

            int count = 0;

            for (int i = 0; i < looseSocks.Count; i++)
            {
                if (looseSocks[i] == string.Empty)
                {
                    continue;
                }

                if (i == looseSocks.Count-1)
                {
                    break;
                }

                for (int j = i+1; j < looseSocks.Count; j++)
                {
                    if (looseSocks[j] == string.Empty)
                    {
                        continue;
                    }

                    if (looseSocks[i] == looseSocks[j])
                    {
                        count++;

                        looseSocks[i] = string.Empty;
                        looseSocks[j] = string.Empty;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
