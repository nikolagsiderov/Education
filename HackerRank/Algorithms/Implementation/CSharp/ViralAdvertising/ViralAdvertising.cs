using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViralAdvertising
{
    class ViralAdvertising
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int shared = 5;
            int liked = 2;

            for (int i = 2; i <= days; i++)
            {
                shared = shared / 2 * 3;
                liked = liked + shared / 2;
            }

            Console.WriteLine(liked);
        }
    }
}
