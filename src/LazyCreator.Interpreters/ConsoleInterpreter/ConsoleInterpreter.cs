using System;
using System.Linq;
using System.Reflection;
using LazyCreator.Commands;

namespace LazyCreator.Interpreters.ConsoleInterpreter
{
    public class ConsoleInterpreter : IConsoleInterpreter
    {
        public string ExecuteCommand(string[] args)
        {
            try
            {
                return GetInstance(args).Execute(args.Skip(1).ToArray());
            }
            catch (Exception exception)
            {
                return $"{args[0]} is not a valid command!";
            }
        }

        public string GetCommandOutOfRawStringArray(string[] rawInput)
        {
            return rawInput[0];
        }

        private Type GetCommandType(string commandName)
        {
            return Assembly.Load("LazyCreator.Commands").GetTypes()
                .Where(x => x.Name.ToLower() == commandName.ToLower() + "command")
                .ToList()[0];
        }

        private ICommand GetInstance(string[] input)
        {
            var commandName = GetCommandOutOfRawStringArray(input);
            var commandType = GetCommandType(commandName);

            var instance = Activator.CreateInstance(commandType) as ICommand;
            return instance;
        }
    }
}