namespace CommandInterpreter
{
    public class Logger
    {
        public Logger(string path)
        {
            this.Path = path;
        }

        public string Path { get; set; }
    }
}
