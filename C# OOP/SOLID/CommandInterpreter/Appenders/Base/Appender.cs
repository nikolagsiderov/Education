using CommandInterpreter.Appenders.Contracts;
using System;

namespace CommandInterpreter.Appenders.Base
{
    public class Appender : IAppender
    {
        public Appender(string appenderType, string layoutType)
        {
            this.AppenderType = appenderType;
            this.LayoutType = layoutType;
        }

        public string AppenderType { get; set; }

        public string LayoutType { get; set; }

        public string ReportLevel { get; set; }

        public virtual void Write(string time, string reportLevel, string message)
        {
            Console.WriteLine($"{time} - {reportLevel} - {message}");
        }
    }
}
