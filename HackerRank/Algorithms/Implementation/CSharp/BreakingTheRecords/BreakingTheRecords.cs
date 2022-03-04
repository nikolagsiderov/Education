using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecords
{
    class BreakingTheRecords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> scores = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int highScoresCount = 0;
            int lowScoresCount = 0;

            int highScores = scores[0];
            int lowScores = scores[0];

            for (int i = 1; i < scores.Count; i++)
            {
                if (scores[i] > highScores)
                {
                    highScores = scores[i];
                    highScoresCount++;
                }

                if (scores[i] < lowScores)
                {
                    lowScores = scores[i];
                    lowScoresCount++;
                }
            }

            Console.WriteLine($"{highScoresCount} {lowScoresCount}");
        }
    }
}
