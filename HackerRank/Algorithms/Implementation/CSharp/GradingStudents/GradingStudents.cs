using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudents
{
    class GradingStudents
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> grades = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int gradeOfCurrentStudent = int.Parse(Console.ReadLine());

                grades.Add(gradeOfCurrentStudent);
            }

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38 || grades[i] % 5 != 0)
                {
                    grades[i] = RoundGrade(grades[i]);
                }
            }

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
        static int RoundGrade(int grade)
        {
            int initialGrade = grade;

            if (initialGrade < 38)
            {
                return initialGrade;
            }

            if (grade % 5 < 2.5)
            {
                grade = 5 + grade - grade % 5;
            }
            else
            {
                grade = grade + (5 - grade % 5);
            }

            if (Math.Abs(initialGrade - grade) < 3)
            {
                return grade;
            }
            else
            {
                return initialGrade;
            }
        }
    }
}
