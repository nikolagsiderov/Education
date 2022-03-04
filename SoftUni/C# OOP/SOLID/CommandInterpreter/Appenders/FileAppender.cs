using CommandInterpreter.Appenders.Base;
using System.IO;

namespace CommandInterpreter.Appenders
{
    public class FileAppender : Appender
    {
        public FileAppender(string appenderType, string layoutType) : base(appenderType, layoutType)
        {
        }

        public void Write(Logger logger, string time, string reportLevel, string message)
        {
            File.WriteAllText($"{logger.Path}",
                $"<log><date>{time}</date><level>{reportLevel}</level><message>{message}</message></log>");
        }
    }
}
