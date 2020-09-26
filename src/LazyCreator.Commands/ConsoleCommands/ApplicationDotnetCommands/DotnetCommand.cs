namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class ConsoleCommand : IDotnetCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.WindowsDefaultCommandLineProgram,
                ApplicationDefaults.DotnetConsoleApplication(args));

            return null;
        }
    }
}