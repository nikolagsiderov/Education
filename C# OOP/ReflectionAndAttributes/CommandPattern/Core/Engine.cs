using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class Engine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run(string input)
        {
            commandInterpreter.Read(input);
        }
    }
}
