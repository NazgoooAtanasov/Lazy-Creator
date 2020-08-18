namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class DotnetCommand : IDotnetCommand
    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.LinuxDefaultShell,
                ApplicationDefaults.DotnetConsoleApplication(args));

            return null;
        }
    }
}