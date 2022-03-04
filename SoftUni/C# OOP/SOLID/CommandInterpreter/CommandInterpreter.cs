using CommandInterpreter.Appenders.Base;
using System;
using System.Collections.Generic;

namespace CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var numberOfAppenders = int.Parse(Console.ReadLine());
            var appenders = new List<Appender>();

            for (int i = 0; i < numberOfAppenders; i++)
            {
                var appenderInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var appender = new Appender(appenderInfo[0], appenderInfo[1]);
                var reportLevel = string.Empty;

                if (appenderInfo.Length > 2)
                    appender.ReportLevel = appenderInfo[2];

                appenders.Add(appender);
            }

            var message = Console.ReadLine();

            while (message != "END")
            {
                var reportLevel = message.Split('|', StringSplitOptions.RemoveEmptyEntries)[0];
                var time = message.Split('|', StringSplitOptions.RemoveEmptyEntries)[1];
                var messageMessage = message.Split('|', StringSplitOptions.RemoveEmptyEntries)[2];

                foreach (var appender in appenders)
                {
                    appender.Write(time, reportLevel, messageMessage);
                }
            }
        }
    }
}
