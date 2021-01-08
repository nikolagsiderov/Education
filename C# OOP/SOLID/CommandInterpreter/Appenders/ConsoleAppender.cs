using CommandInterpreter.Appenders.Base;
using System;

namespace CommandInterpreter.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(string appenderType, string layoutType) : base(appenderType, layoutType)
        {
        }
    }
}
