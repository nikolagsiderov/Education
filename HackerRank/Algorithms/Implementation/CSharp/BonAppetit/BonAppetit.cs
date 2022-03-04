using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class BonAppetit
    {
        static void Main(string[] args)
        {
            List<int> itemsAndIndexOfFalseItem = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int items = itemsAndIndexOfFalseItem[0];
            int indexOfFalseItem = itemsAndIndexOfFalseItem[1];

            List<int> itemsPrices = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int charged = int.Parse(Console.ReadLine());

            itemsPrices[indexOfFalseItem] = 0;

            int totalSum = itemsPrices.Sum();

            if (totalSum/2 == charged)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(charged-totalSum/2);
            }
        }
    }
}
