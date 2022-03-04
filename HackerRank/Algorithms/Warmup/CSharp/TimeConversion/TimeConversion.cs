using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class TimeConversion
    {
        static void Main(string[] args)
        {
            string inputTime = Console.ReadLine();

            if (inputTime[inputTime.Length-2] == 'P') // PM
            {
                string outputHour = string.Empty;

                int hour = int.Parse(inputTime[0].ToString() + inputTime[1].ToString());
                
                if (hour == 12)
                {
                    outputHour = hour.ToString();
                }
                else if (hour < 12)
                {
                    hour += 12;
                    outputHour = hour.ToString();
                }
                else
                {
                    outputHour = hour.ToString();
                }

                inputTime = inputTime.Remove(0, 2);
                inputTime = inputTime.Insert(0, outputHour);
                inputTime = inputTime.Remove(inputTime.Length - 2);

                DateTime time = DateTime.Parse(inputTime, CultureInfo.InvariantCulture);

                Console.WriteLine("{0:HH:mm:ss}", time);
            }
            else if (inputTime[inputTime.Length-2] == 'A') // AM
            {
                string outputHour = string.Empty;

                int hour = int.Parse(inputTime[0].ToString() + inputTime[1].ToString());

                if (hour == 12)
                {
                    outputHour = "00";
                }
                else if (hour < 12)
                {
                    outputHour = hour.ToString();
                }
                else
                {
                    hour -= 12;
                    outputHour = hour.ToString();
                }

                inputTime = inputTime.Remove(0, 2);
                inputTime = inputTime.Insert(0, outputHour);
                inputTime = inputTime.Remove(inputTime.Length - 2);

                DateTime time = DateTime.Parse(inputTime, CultureInfo.InvariantCulture);

                Console.WriteLine("{0:HH:mm:ss}", time);
            }
        }
    }
}
