using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class AppleAndOrange
    {
        static void Main(string[] args)
        {
            List<int> houseWidthCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> treeCoordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> applesAndOrangesCount = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> appleFallsCoordinates = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> orangeFallsCoordinates = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> applesFinalCoordinates = new List<int>();
            List<int> orangeFinalCoordinates = new List<int>();

            int appleFallsOnHouse = 0;
            int orangeFallsOnHouse = 0;

            for (int i = 0; i < appleFallsCoordinates.Count; i++)
            {
                int currentApple = appleFallsCoordinates[i];
                currentApple = treeCoordinates[0] + currentApple;

                if (currentApple >= houseWidthCoordinates[0] && currentApple <= houseWidthCoordinates[1])
                {
                    appleFallsOnHouse++;
                }
            }

            for (int i = 0; i < orangeFallsCoordinates.Count; i++)
            {
                int currentOrange = orangeFallsCoordinates[i];
                currentOrange = treeCoordinates[1] + currentOrange;

                if (currentOrange >= houseWidthCoordinates[0] && currentOrange <= houseWidthCoordinates[1])
                {
                    orangeFallsOnHouse++;
                }
            }

            Console.WriteLine(appleFallsOnHouse);
            Console.WriteLine(orangeFallsOnHouse);
        }
    }
}
