namespace CommandPattern.Core
{
    public class HelloCommand : CommandInterpreter
    {
        public override string Execute(string[] args)
        {
            return $"Hello, {args[0]}";
        }
    }
}
