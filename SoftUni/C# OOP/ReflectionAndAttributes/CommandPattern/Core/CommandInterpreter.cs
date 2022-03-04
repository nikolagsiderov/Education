using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public CommandInterpreter() => Read(Console.ReadLine());

        public string Read(string args)
        {
            Execute(args.Split(' '));
        }

        public virtual void Execute(string[] args)
        {

        }
    }
}
