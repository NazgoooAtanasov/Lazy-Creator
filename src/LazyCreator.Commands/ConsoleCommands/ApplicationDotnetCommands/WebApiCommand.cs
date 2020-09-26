namespace LazyCreator.Commands.ConsoleCommands.ApplicationDotnetCommands
{
    public class WebApiCommand : IDotnetCommand

    {
        public string Execute(string[] args)
        {
            TerminalExecutor.Run(
                ApplicationDefaults.WindowsDefaultCommandLineProgram,
                ApplicationDefaults.DotnetWebApi(args));
            return null;
        }
    }
}