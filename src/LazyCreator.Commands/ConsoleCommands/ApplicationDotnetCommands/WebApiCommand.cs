namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class WebApiCommand : IDotnetCommand

    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.LinuxDefaultShell,
                ApplicationDefaults.DotnetWebApi(args));
            return null;
        }
    }
}