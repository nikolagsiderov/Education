using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class AngryProfessor
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                List<int> inputParams = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> studentsTimeArrival = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                
                int minNumberOfAttendance = inputParams[1];
                int count = 0;

                for (int j = 0; j < studentsTimeArrival.Count; j++)
                {
                    if (studentsTimeArrival[j] <= 0)
                    {
                        count++;
                    }
                }

                if (count >= minNumberOfAttendance)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }
    }
}
