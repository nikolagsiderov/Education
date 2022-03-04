using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfTheProgrammer
{
    class DayOfTheProgrammer
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());

            if (inputYear >= 1700 && inputYear <= 1917)
            {
                if (inputYear % 4.0 == 0)
                {
                    Console.WriteLine("12.09.{0}", inputYear.ToString());
                }
                else
                {
                    Console.WriteLine("13.09.{0}", inputYear.ToString());
                }
            }
            else if (inputYear == 1918)
            {
                Console.WriteLine("26.09.1918");
            }
            else if (inputYear > 1918)
            {
                if (DateTime.IsLeapYear(inputYear))
                {
                    Console.WriteLine("12.09.{0}", inputYear.ToString());
                }
                else
                {
                    Console.WriteLine("13.09.{0}", inputYear.ToString());
                }
            }
        }
    }
}
