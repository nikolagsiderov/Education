namespace CommandInterpreter.Appenders.Contracts
{
    public interface IAppender
    {
        public string AppenderType { get; set; }

        public string LayoutType { get; set; }
    }
}
