using System;

namespace LazyCreator.Commands.ConsoleCommands.ApplicationExitCommand
{
    public class ExitCommand : IExitCommand
    {
        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return null;
        }
    }
}